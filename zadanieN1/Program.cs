using System;
using System.IO;


namespace zadanieN1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i != n; i++)
            {
                array[i] = rnd.Next(-100,100);
            }
            string path = @"D:\test.txt";

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i!= n; i++)
                {
                    sw.WriteLine(array[i]);
                }
            }
        }
    }
}
