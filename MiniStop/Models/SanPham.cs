namespace MiniStop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        public long MaSP { get; set; }

        public long? MaNCC { get; set; }

        public long? MaLoaiSP { get; set; }

        [StringLength(200)]
        public string TenSP { get; set; }

        public string HinhAnh { get; set; }

        [StringLength(200)]
        public string ThuongHieu { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaBan { get; set; }

        public string Mota { get; set; }

        public int? SoLuong { get; set; }

        public DateTime NgayThem { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public double GiamGia { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaMoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
