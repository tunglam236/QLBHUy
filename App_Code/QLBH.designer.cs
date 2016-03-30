﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBH")]
public partial class QLBHDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Inserttbl_DonViTinh(tbl_DonViTinh instance);
  partial void Updatetbl_DonViTinh(tbl_DonViTinh instance);
  partial void Deletetbl_DonViTinh(tbl_DonViTinh instance);
  partial void Inserttbl_ThanhPham(tbl_ThanhPham instance);
  partial void Updatetbl_ThanhPham(tbl_ThanhPham instance);
  partial void Deletetbl_ThanhPham(tbl_ThanhPham instance);
  partial void Inserttbl_NhomHang(tbl_NhomHang instance);
  partial void Updatetbl_NhomHang(tbl_NhomHang instance);
  partial void Deletetbl_NhomHang(tbl_NhomHang instance);
  partial void Inserttbl_KhachHang(tbl_KhachHang instance);
  partial void Updatetbl_KhachHang(tbl_KhachHang instance);
  partial void Deletetbl_KhachHang(tbl_KhachHang instance);
  partial void Inserttbl_NCC(tbl_NCC instance);
  partial void Updatetbl_NCC(tbl_NCC instance);
  partial void Deletetbl_NCC(tbl_NCC instance);
  #endregion
	
	public QLBHDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBHConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public QLBHDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public QLBHDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public QLBHDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public QLBHDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<tbl_DonViTinh> tbl_DonViTinhs
	{
		get
		{
			return this.GetTable<tbl_DonViTinh>();
		}
	}
	
	public System.Data.Linq.Table<tbl_ThanhPham> tbl_ThanhPhams
	{
		get
		{
			return this.GetTable<tbl_ThanhPham>();
		}
	}
	
	public System.Data.Linq.Table<tbl_NhomHang> tbl_NhomHangs
	{
		get
		{
			return this.GetTable<tbl_NhomHang>();
		}
	}
	
	public System.Data.Linq.Table<tbl_KhachHang> tbl_KhachHangs
	{
		get
		{
			return this.GetTable<tbl_KhachHang>();
		}
	}
	
	public System.Data.Linq.Table<tbl_NCC> tbl_NCCs
	{
		get
		{
			return this.GetTable<tbl_NCC>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_DonViTinh")]
public partial class tbl_DonViTinh : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _TenDonViTinh;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenDonViTinhChanging(string value);
    partial void OnTenDonViTinhChanged();
    #endregion
	
	public tbl_DonViTinh()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonViTinh", DbType="NVarChar(50)")]
	public string TenDonViTinh
	{
		get
		{
			return this._TenDonViTinh;
		}
		set
		{
			if ((this._TenDonViTinh != value))
			{
				this.OnTenDonViTinhChanging(value);
				this.SendPropertyChanging();
				this._TenDonViTinh = value;
				this.SendPropertyChanged("TenDonViTinh");
				this.OnTenDonViTinhChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_ThanhPham")]
public partial class tbl_ThanhPham : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _TenThanhPham;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenThanhPhamChanging(string value);
    partial void OnTenThanhPhamChanged();
    #endregion
	
	public tbl_ThanhPham()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenThanhPham", DbType="NVarChar(150)")]
	public string TenThanhPham
	{
		get
		{
			return this._TenThanhPham;
		}
		set
		{
			if ((this._TenThanhPham != value))
			{
				this.OnTenThanhPhamChanging(value);
				this.SendPropertyChanging();
				this._TenThanhPham = value;
				this.SendPropertyChanged("TenThanhPham");
				this.OnTenThanhPhamChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_NhomHang")]
public partial class tbl_NhomHang : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _TenNhomHang;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenNhomHangChanging(string value);
    partial void OnTenNhomHangChanged();
    #endregion
	
	public tbl_NhomHang()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhomHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string TenNhomHang
	{
		get
		{
			return this._TenNhomHang;
		}
		set
		{
			if ((this._TenNhomHang != value))
			{
				this.OnTenNhomHangChanging(value);
				this.SendPropertyChanging();
				this._TenNhomHang = value;
				this.SendPropertyChanged("TenNhomHang");
				this.OnTenNhomHangChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_KhachHang")]
public partial class tbl_KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _TenKH;
	
	private string _NgaySinh;
	
	private System.Nullable<int> _MST;
	
	private string _Email;
	
	private string _DiaChi;
	
	private string _SDT;
	
	private byte _LoaiKH;
	
	private string _GhiChu;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnMSTChanging(System.Nullable<int> value);
    partial void OnMSTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnLoaiKHChanging(byte value);
    partial void OnLoaiKHChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
	
	public tbl_KhachHang()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
	public string TenKH
	{
		get
		{
			return this._TenKH;
		}
		set
		{
			if ((this._TenKH != value))
			{
				this.OnTenKHChanging(value);
				this.SendPropertyChanging();
				this._TenKH = value;
				this.SendPropertyChanged("TenKH");
				this.OnTenKHChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="VarChar(50)")]
	public string NgaySinh
	{
		get
		{
			return this._NgaySinh;
		}
		set
		{
			if ((this._NgaySinh != value))
			{
				this.OnNgaySinhChanging(value);
				this.SendPropertyChanging();
				this._NgaySinh = value;
				this.SendPropertyChanged("NgaySinh");
				this.OnNgaySinhChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MST", DbType="Int")]
	public System.Nullable<int> MST
	{
		get
		{
			return this._MST;
		}
		set
		{
			if ((this._MST != value))
			{
				this.OnMSTChanging(value);
				this.SendPropertyChanging();
				this._MST = value;
				this.SendPropertyChanged("MST");
				this.OnMSTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(150)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(350)")]
	public string DiaChi
	{
		get
		{
			return this._DiaChi;
		}
		set
		{
			if ((this._DiaChi != value))
			{
				this.OnDiaChiChanging(value);
				this.SendPropertyChanging();
				this._DiaChi = value;
				this.SendPropertyChanged("DiaChi");
				this.OnDiaChiChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(20)")]
	public string SDT
	{
		get
		{
			return this._SDT;
		}
		set
		{
			if ((this._SDT != value))
			{
				this.OnSDTChanging(value);
				this.SendPropertyChanging();
				this._SDT = value;
				this.SendPropertyChanged("SDT");
				this.OnSDTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiKH", DbType="TinyInt NOT NULL")]
	public byte LoaiKH
	{
		get
		{
			return this._LoaiKH;
		}
		set
		{
			if ((this._LoaiKH != value))
			{
				this.OnLoaiKHChanging(value);
				this.SendPropertyChanging();
				this._LoaiKH = value;
				this.SendPropertyChanged("LoaiKH");
				this.OnLoaiKHChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(MAX)")]
	public string GhiChu
	{
		get
		{
			return this._GhiChu;
		}
		set
		{
			if ((this._GhiChu != value))
			{
				this.OnGhiChuChanging(value);
				this.SendPropertyChanging();
				this._GhiChu = value;
				this.SendPropertyChanged("GhiChu");
				this.OnGhiChuChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_NCC")]
public partial class tbl_NCC : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _TenNCC;
	
	private string _CongTy;
	
	private string _Email;
	
	private string _SDT;
	
	private string _DiaChi;
	
	private string _MST;
	
	private string _GhiChu;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnCongTyChanging(string value);
    partial void OnCongTyChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnMSTChanging(string value);
    partial void OnMSTChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
	
	public tbl_NCC()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
	public string TenNCC
	{
		get
		{
			return this._TenNCC;
		}
		set
		{
			if ((this._TenNCC != value))
			{
				this.OnTenNCCChanging(value);
				this.SendPropertyChanging();
				this._TenNCC = value;
				this.SendPropertyChanged("TenNCC");
				this.OnTenNCCChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongTy", DbType="NVarChar(250)")]
	public string CongTy
	{
		get
		{
			return this._CongTy;
		}
		set
		{
			if ((this._CongTy != value))
			{
				this.OnCongTyChanging(value);
				this.SendPropertyChanging();
				this._CongTy = value;
				this.SendPropertyChanged("CongTy");
				this.OnCongTyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(150)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(20)")]
	public string SDT
	{
		get
		{
			return this._SDT;
		}
		set
		{
			if ((this._SDT != value))
			{
				this.OnSDTChanging(value);
				this.SendPropertyChanging();
				this._SDT = value;
				this.SendPropertyChanged("SDT");
				this.OnSDTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(150)")]
	public string DiaChi
	{
		get
		{
			return this._DiaChi;
		}
		set
		{
			if ((this._DiaChi != value))
			{
				this.OnDiaChiChanging(value);
				this.SendPropertyChanging();
				this._DiaChi = value;
				this.SendPropertyChanged("DiaChi");
				this.OnDiaChiChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MST", DbType="NVarChar(150)")]
	public string MST
	{
		get
		{
			return this._MST;
		}
		set
		{
			if ((this._MST != value))
			{
				this.OnMSTChanging(value);
				this.SendPropertyChanging();
				this._MST = value;
				this.SendPropertyChanged("MST");
				this.OnMSTChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(MAX)")]
	public string GhiChu
	{
		get
		{
			return this._GhiChu;
		}
		set
		{
			if ((this._GhiChu != value))
			{
				this.OnGhiChuChanging(value);
				this.SendPropertyChanging();
				this._GhiChu = value;
				this.SendPropertyChanged("GhiChu");
				this.OnGhiChuChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
