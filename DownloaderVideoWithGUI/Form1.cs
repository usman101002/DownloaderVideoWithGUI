using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace DownloaderVideoWithGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadVieoFromUrl(string url, string path)
        {
            var youtube = YouTube.Default;
            var video = youtube.GetVideo(url ?? string.Empty);
            File.WriteAllBytes(path + @"\" + video.FullName, video.GetBytes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty) && (textBox2.Text == string.Empty))
            {
                MessageBox.Show("Введите URL и путь к скачиванию");
                return;
            }

            MessageBox.Show("Закачка началась...");
            DownloadVieoFromUrl(textBox1.Text, textBox2.Text);
            MessageBox.Show("Скачивание завершено");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
