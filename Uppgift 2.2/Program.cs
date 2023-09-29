using System;
namespace uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt kunde du hoppa Elin?");
            string elin = Console.ReadLine();
            int hoplängd = int.Parse(elin);
            Console.WriteLine("hur långt kunde du hoppa Alma?");
            string alma = Console.ReadLine();
            int hopplängd2 = int.Parse(alma);
            int skillnaden = hoplängd - hopplängd2;
            Console.WriteLine("Elin hoppade " + elin + " meter lång och alma hoppade " + alma + " meter lång och skillnaden mellan de är " + skillnaden);
        }
    }
}