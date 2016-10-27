namespace Egs.PropertyTypes
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ComponentModel;
    using Egs;
    using Egs.DotNetUtility;

    // NOTE: These values are generated by some tool, devices has same value, and these values were going to used in USB protocol, but not used.  Do not change the values.
    [DataContract]
    internal enum HidAccessPropertyPrimitiveTypeIds
    {
        TypeId_byte = 0x1092069,
        TypeId_bool = 0x27630E1,
        TypeId_short = 0xEDD40A,
        TypeId_ushort = 0x216F5A6,
        TypeId_int = 0x1AD579D,
        TypeId_uint = 0xC30841,
        TypeId_float = 0x33C528B,
    }
}