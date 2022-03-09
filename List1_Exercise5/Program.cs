using System;

namespace List1_Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int days = 0, year1, year2, j, older = 0, last = 0 ;

            Console.Write("Enter a year: ");
            year1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a different year: ");
            year2 = int.Parse(Console.ReadLine());

            if (year1 > year2)
            {

                older = year2;
                last = year1;

            }
            else if (year1 < year2)
            {

                older = year1;
                last = year2;

            }

            for(int i = older; i < last; i++)
            {

                if((i % 4 == 0 & i % 100 != 0) || (i % 400 == 0))
                {

                    j = 366;

                }
                else
                {

                    j = 365;

                }
                days = days + j;
            }

            Console.WriteLine($"There are {days} between {older} and {last}");

            Console.ReadKey();

        }
    }
}
