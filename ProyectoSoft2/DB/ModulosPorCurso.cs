//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoSoft2.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModulosPorCurso
    {
        public int IdModuloPorCurso { get; set; }
        public int IdModulo { get; set; }
        public int IdCurso { get; set; }
    
        public virtual Cursos Cursos { get; set; }
        public virtual Modulos Modulos { get; set; }
    }
}
