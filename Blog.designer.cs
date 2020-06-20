﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
	public partial class BlogDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBanTin(BanTin instance);
    partial void UpdateBanTin(BanTin instance);
    partial void DeleteBanTin(BanTin instance);
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    #endregion
		
		public BlogDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BanTin> BanTins
		{
			get
			{
				return this.GetTable<BanTin>();
			}
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Delete")]
		public int BanTin_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DangNhap_Search")]
		public ISingleResult<DangNhap_SearchResult> DangNhap_Search([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string passWord)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, passWord);
			return ((ISingleResult<DangNhap_SearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Insert", IsComposable=true)]
		public object BanTin_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string noiDung)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), noiDung).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_SelectAll")]
		public ISingleResult<BanTin_SelectAllResult> BanTin_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<BanTin_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Update", IsComposable=true)]
		public object BanTin_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			return ((object)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), noiDung, iDBanTin).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Insert")]
		public int ChiTiet_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> ngayDang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tieuDe, noiDung, ngayDang, iDBanTin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_LanXem")]
		public int ChiTiet_LanXem([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> lanXem)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, lanXem);
			lanXem = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SELECT")]
		public ISingleResult<ChiTiet_SELECTResult> ChiTiet_SELECT([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<ChiTiet_SELECTResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectAll")]
		public ISingleResult<ChiTiet_SelectAllResult> ChiTiet_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectHome")]
		public ISingleResult<ChiTiet_SelectHomeResult> ChiTiet_SelectHome()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectHomeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectRanRom")]
		public ISingleResult<ChiTiet_SelectRanRomResult> ChiTiet_SelectRanRom([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<ChiTiet_SelectRanRomResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SLX")]
		public int ChiTiet_SLX([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> lanXem, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), lanXem, iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Update")]
		public int ChiTiet_Update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tieuDe, noiDung, iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DangNhap_Insert")]
		public int DangNhap_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string passWord)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, passWord);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_SelectID")]
		public ISingleResult<BanTin_SelectIDResult> BanTin_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<BanTin_SelectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectID")]
		public ISingleResult<ChiTiet_SelectIDResult> ChiTiet_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<ChiTiet_SelectIDResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BanTin")]
	public partial class BanTin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDBanTin;
		
		private string _tenBanTin;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBanTinChanging(int value);
    partial void OnIDBanTinChanged();
    partial void OntenBanTinChanging(string value);
    partial void OntenBanTinChanged();
    #endregion
		
		public BanTin()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this.OnIDBanTinChanging(value);
					this.SendPropertyChanging();
					this._IDBanTin = value;
					this.SendPropertyChanged("IDBanTin");
					this.OnIDBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenBanTin", DbType="NVarChar(50)")]
		public string tenBanTin
		{
			get
			{
				return this._tenBanTin;
			}
			set
			{
				if ((this._tenBanTin != value))
				{
					this.OntenBanTinChanging(value);
					this.SendPropertyChanging();
					this._tenBanTin = value;
					this.SendPropertyChanged("tenBanTin");
					this.OntenBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanTin_ChiTiet", Storage="_ChiTiets", ThisKey="IDBanTin", OtherKey="IDBanTin")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
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
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.BanTin = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.BanTin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap
	{
		
		private int _IDName;
		
		private string _userName;
		
		private string _passWord;
		
		public DangNhap()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDName", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int IDName
		{
			get
			{
				return this._IDName;
			}
			set
			{
				if ((this._IDName != value))
				{
					this._IDName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NVarChar(50)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this._userName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passWord", DbType="NVarChar(50)")]
		public string passWord
		{
			get
			{
				return this._passWord;
			}
			set
			{
				if ((this._passWord != value))
				{
					this._passWord = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		private EntityRef<BanTin> _BanTin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OntieuDeChanging(string value);
    partial void OntieuDeChanged();
    partial void OnnoiDungChanging(string value);
    partial void OnnoiDungChanged();
    partial void OnlanXemChanging(System.Nullable<int> value);
    partial void OnlanXemChanged();
    partial void OnngayDangChanging(System.Nullable<System.DateTime> value);
    partial void OnngayDangChanged();
    partial void OnIDBanTinChanging(System.Nullable<int> value);
    partial void OnIDBanTinChanged();
    #endregion
		
		public ChiTiet()
		{
			this._BanTin = default(EntityRef<BanTin>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this.OntieuDeChanging(value);
					this.SendPropertyChanging();
					this._tieuDe = value;
					this.SendPropertyChanged("tieuDe");
					this.OntieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this.OnnoiDungChanging(value);
					this.SendPropertyChanging();
					this._noiDung = value;
					this.SendPropertyChanged("noiDung");
					this.OnnoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this.OnlanXemChanging(value);
					this.SendPropertyChanging();
					this._lanXem = value;
					this.SendPropertyChanged("lanXem");
					this.OnlanXemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this.OnngayDangChanging(value);
					this.SendPropertyChanging();
					this._ngayDang = value;
					this.SendPropertyChanged("ngayDang");
					this.OnngayDangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					if (this._BanTin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBanTinChanging(value);
					this.SendPropertyChanging();
					this._IDBanTin = value;
					this.SendPropertyChanged("IDBanTin");
					this.OnIDBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanTin_ChiTiet", Storage="_BanTin", ThisKey="IDBanTin", OtherKey="IDBanTin", IsForeignKey=true)]
		public BanTin BanTin
		{
			get
			{
				return this._BanTin.Entity;
			}
			set
			{
				BanTin previousValue = this._BanTin.Entity;
				if (((previousValue != value) 
							|| (this._BanTin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BanTin.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._BanTin.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._IDBanTin = value.IDBanTin;
					}
					else
					{
						this._IDBanTin = default(Nullable<int>);
					}
					this.SendPropertyChanged("BanTin");
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
	
	public partial class DangNhap_SearchResult
	{
		
		private int _IDName;
		
		private string _userName;
		
		private string _passWord;
		
		public DangNhap_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDName", DbType="Int NOT NULL")]
		public int IDName
		{
			get
			{
				return this._IDName;
			}
			set
			{
				if ((this._IDName != value))
				{
					this._IDName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NVarChar(50)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this._userName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passWord", DbType="NVarChar(50)")]
		public string passWord
		{
			get
			{
				return this._passWord;
			}
			set
			{
				if ((this._passWord != value))
				{
					this._passWord = value;
				}
			}
		}
	}
	
	public partial class BanTin_SelectAllResult
	{
		
		private int _IDBanTin;
		
		private string _tenBanTin;
		
		public BanTin_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenBanTin", DbType="NVarChar(50)")]
		public string tenBanTin
		{
			get
			{
				return this._tenBanTin;
			}
			set
			{
				if ((this._tenBanTin != value))
				{
					this._tenBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SELECTResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SELECTResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectAllResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectHomeResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectHomeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectRanRomResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectRanRomResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class BanTin_SelectIDResult
	{
		
		private int _IDBanTin;
		
		private string _tenBanTin;
		
		public BanTin_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenBanTin", DbType="NVarChar(50)")]
		public string tenBanTin
		{
			get
			{
				return this._tenBanTin;
			}
			set
			{
				if ((this._tenBanTin != value))
				{
					this._tenBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectIDResult
	{
		
		private int _ID;
		
		private string _tieuDe;
		
		private string _noiDung;
		
		private System.Nullable<int> _lanXem;
		
		private System.Nullable<System.DateTime> _ngayDang;
		
		private System.Nullable<int> _IDBanTin;
		
		public ChiTiet_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
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
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tieuDe", DbType="NVarChar(200)")]
		public string tieuDe
		{
			get
			{
				return this._tieuDe;
			}
			set
			{
				if ((this._tieuDe != value))
				{
					this._tieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_noiDung", DbType="NVarChar(MAX)")]
		public string noiDung
		{
			get
			{
				return this._noiDung;
			}
			set
			{
				if ((this._noiDung != value))
				{
					this._noiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lanXem", DbType="Int")]
		public System.Nullable<int> lanXem
		{
			get
			{
				return this._lanXem;
			}
			set
			{
				if ((this._lanXem != value))
				{
					this._lanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngayDang
		{
			get
			{
				return this._ngayDang;
			}
			set
			{
				if ((this._ngayDang != value))
				{
					this._ngayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int")]
		public System.Nullable<int> IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
