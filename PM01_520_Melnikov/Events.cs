//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM01_520_Melnikov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
        public int City_ID { get; set; }
        public string Logo { get; set; }
    
        public virtual City City { get; set; }
    }
}
