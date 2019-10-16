using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super_mercato_500_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo totale: ");
            double totale = double.Parse(Console.ReadLine());
            double s = totale * 20 / 100;
            double s2 = totale * 10 / 100;
            if (totale > 500)
            {
                double totalescontato = totale - s;
                Console.WriteLine($"il prezzo scontato è:{totalescontato} ");
            }
            else
            {
                double totalescontato2 = totale - s2;
                Console.WriteLine($"l' importo è: {totalescontato2}");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
