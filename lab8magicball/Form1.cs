using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8magicball
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double[] prob = { 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125, 0.125};
        string[] pred = { "Без сомнения", "Знаки говорят — «да»", "Вероятнее всего", "Спроси позже", "Ну такое", "Весьма сомнительно", "Даже не думай", "Сейчас самое подходящее время!"};
        Random r = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            double summ = 0;

			for (int i = 0; i < 8; i++)
            {
                summ += prob[i];
                a = r.NextDouble();
				if (a < summ) 
                {
					label2.Text = "Ответ:";
					label3.Text = pred[i]; 
                    break; 
                }
			}
			if (textBox1.Text == "")
			{
				label2.Text = "А на что отвечать?...";
				label3.Text = "Здесь мог быть ваш ответ...";
			}
		}

	}  
}
