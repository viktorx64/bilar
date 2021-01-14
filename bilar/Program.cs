using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilar
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        
    }

    interface ICar
    {
        void Distance();
        void Service();
        void Cost();
        void Broken();
    }

    class Car : ICar
    {
        public void Distance ()
        {
            Console.WriteLine("car has ran 2000Mil");
        }
        public void Service()
        {
            Console.WriteLine("car was last serviced 2020-05-14");
        }
        public void Cost()
        {
            Console.WriteLine("car cost 15 000 sek");
        }
        public void Broken()
        {
            Console.WriteLine("car has a scratch on the rear-left door");
        }
    }
}
