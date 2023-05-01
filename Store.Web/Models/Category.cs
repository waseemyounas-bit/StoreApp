﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Store.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
        //public int? ParentId { get; set; }
        //[ForeignKey("ParentId")]
        //public Category? Parent { get; set; }
        //public ICollection<Category>? Children { get; set; }

    }
}
