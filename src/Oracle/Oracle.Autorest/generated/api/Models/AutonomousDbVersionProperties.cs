// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Extensions;

    /// <summary>AutonomousDbVersion resource model</summary>
    public partial class AutonomousDbVersionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DbWorkload" /> property.</summary>
        private string _dbWorkload;

        /// <summary>The Autonomous Database workload type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string DbWorkload { get => this._dbWorkload; }

        /// <summary>Backing field for <see cref="IsDefaultForFree" /> property.</summary>
        private bool? _isDefaultForFree;

        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public bool? IsDefaultForFree { get => this._isDefaultForFree; }

        /// <summary>Backing field for <see cref="IsDefaultForPaid" /> property.</summary>
        private bool? _isDefaultForPaid;

        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public bool? IsDefaultForPaid { get => this._isDefaultForPaid; }

        /// <summary>Backing field for <see cref="IsFreeTierEnabled" /> property.</summary>
        private bool? _isFreeTierEnabled;

        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public bool? IsFreeTierEnabled { get => this._isFreeTierEnabled; }

        /// <summary>Backing field for <see cref="IsPaidEnabled" /> property.</summary>
        private bool? _isPaidEnabled;

        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public bool? IsPaidEnabled { get => this._isPaidEnabled; }

        /// <summary>Internal Acessors for DbWorkload</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.DbWorkload { get => this._dbWorkload; set { {_dbWorkload = value;} } }

        /// <summary>Internal Acessors for IsDefaultForFree</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.IsDefaultForFree { get => this._isDefaultForFree; set { {_isDefaultForFree = value;} } }

        /// <summary>Internal Acessors for IsDefaultForPaid</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.IsDefaultForPaid { get => this._isDefaultForPaid; set { {_isDefaultForPaid = value;} } }

        /// <summary>Internal Acessors for IsFreeTierEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.IsFreeTierEnabled { get => this._isFreeTierEnabled; set { {_isFreeTierEnabled = value;} } }

        /// <summary>Internal Acessors for IsPaidEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.IsPaidEnabled { get => this._isPaidEnabled; set { {_isPaidEnabled = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDbVersionPropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Supported Autonomous Db versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="AutonomousDbVersionProperties" /> instance.</summary>
        public AutonomousDbVersionProperties()
        {

        }
    }
    /// AutonomousDbVersion resource model
    public partial interface IAutonomousDbVersionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.IJsonSerializable
    {
        /// <summary>The Autonomous Database workload type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Autonomous Database workload type",
        SerializedName = @"dbWorkload",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("OLTP", "DW", "AJD", "APEX")]
        string DbWorkload { get;  }
        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"True if this version of the Oracle Database software's default is free.",
        SerializedName = @"isDefaultForFree",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultForFree { get;  }
        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"True if this version of the Oracle Database software's default is paid.",
        SerializedName = @"isDefaultForPaid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultForPaid { get;  }
        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.",
        SerializedName = @"isFreeTierEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsFreeTierEnabled { get;  }
        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"True if this version of the Oracle Database software has payments enabled.",
        SerializedName = @"isPaidEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPaidEnabled { get;  }
        /// <summary>Supported Autonomous Db versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Supported Autonomous Db versions.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// AutonomousDbVersion resource model
    internal partial interface IAutonomousDbVersionPropertiesInternal

    {
        /// <summary>The Autonomous Database workload type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Oracle.PSArgumentCompleterAttribute("OLTP", "DW", "AJD", "APEX")]
        string DbWorkload { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        bool? IsDefaultForFree { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        bool? IsDefaultForPaid { get; set; }
        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        bool? IsFreeTierEnabled { get; set; }
        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        bool? IsPaidEnabled { get; set; }
        /// <summary>Supported Autonomous Db versions.</summary>
        string Version { get; set; }

    }
}