using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Build
    {
        /// <summary>
		/// поле названия строения
		/// </summary>
		public string name;//""
        /// <summary>
        /// поле площади строения
        /// </summary>
        public double area;//0.0
        /// <summary>
        /// поле количества жильцов
        /// </summary>
        public int kvo;//0
        /// <summary>
        /// поле количества этажей
        /// </summary>
        public int floor;
        /// <summary>
        /// конструктор по умолчанию или без параметров
        /// </summary>
        public Build() { }
        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="name">name</param>
        public Build(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="area">area</param>
        public Build(string name, double area) : this(name)
        {
            this.area = area;
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="area">area</param>
        /// <param name="kvo">kvo</param>
        public Build(string name, double area, int kvo) : this(name, area)
        {
            this.kvo = kvo;
        }
        /// <summary>
        /// Конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="name">название строения</param>
        /// <param name="area">площадь строения</param>
        /// <param name="kvo">кол-во жильцов</param>
        /// <param name="floor">кол-во этажей</param>
        public Build(string name, double area, int kvo, int floor) : this(name, area, kvo)
        {
            this.floor = floor;
        }
        /// <summary>
        /// Метод ShowInfo(), который выводит информацию о строении 
        /// и вычисляет площадь на одного жильца
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"В доме {name} площадью {area} кв. метров живёт {kvo} чел, " +
                $"на человека - {area / kvo:f2} кв. метров");
        }
        /// <summary>
        /// Метод ShowInfo(), который выводит информацию о строении 
        /// и вычисляет площадь на одного жильца
        /// </summary>
        /// <returns>информация о строении</returns>
        public override string ToString()
        {
            return $"В доме {name} площадью {area} кв. метров живёт {kvo} чел, " +
                $"на человека - {area / kvo:f2} кв. метров";
        }
    }
}
