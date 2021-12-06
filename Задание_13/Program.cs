using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        /*Задан класс Building, который описывает здание.Класс содержит следующие элементы:
        - адрес здания;
        - длина здания;
        - ширина здания;
        - высота здания.
        В классе Building нужно реализовать следующие методы:
        - конструктор с 4 параметрами;
        - свойства get/set для доступа к полям класса;
        - метод Print(), который выводит информацию о здании.
        Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
        - конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        - свойство get/set доступа к внутреннему полю класса;
        - метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        Класс MultiBuilding сделать таким, что не может быть унаследован.*/
        static void Main(string[] args)
        {
            Building building = new Building("СПб", 1, 2, 3);
            MultiBuilding multiBuilding = new MultiBuilding("Москва", 4, 5, 6, 7);
            building.Print();
            multiBuilding.Print();
            Console.WriteLine("Для завершения программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    class Building
    {
        string AddressBuilding = "";
        public double LengthBuilding { set; get; }
        public double WidthBuilding { set; get; }
        public double HeigthBuilding { set; get; }
        public Building(string addressBuilding, double lengthBuilding, double widthBuilding, double heigthBuilding)
        {
            AddressBuilding = addressBuilding;
            LengthBuilding = lengthBuilding;
            WidthBuilding = widthBuilding;
            HeigthBuilding = heigthBuilding;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}\nДлина здания: L = {1} м\nШирина здания: B = {2} м\nВысота здания: H = {3} м", AddressBuilding, LengthBuilding, WidthBuilding, HeigthBuilding);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int FloorNumber { set; get; }
        public MultiBuilding(string addressBuilding, double lengthBuilding, double widthBuilding, double heigthBuilding, int floorNumber)
            : base(addressBuilding, lengthBuilding, widthBuilding, heigthBuilding)
        {
            FloorNumber = floorNumber;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей: N = {0}", FloorNumber);
        }
    }
}
