using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            

            carManager.Add(new Entities.Concrete.Car { Id = 1, BrandId = "VOLVO", DailyPrice = 290, ColorId = 4, Description = "Iron Car" });

            


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }

            
           

        }
    }
}
