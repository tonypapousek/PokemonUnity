﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pokemon_Unity_Database_Creator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pokemon_Unity_Database_Creator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to private static int[] expTableErratic = new int[]
        ///    {
        ///        0, 15, 52, 122, 237, 406, 637, 942, 1326, 1800,
        ///        2369, 3041, 3822, 4719, 5737, 6881, 8155, 9564, 11111, 12800,
        ///        14632, 16610, 18737, 21012, 23437, 26012, 28737, 31610, 34632, 37800,
        ///        41111, 44564, 48155, 51881, 55737, 59719, 63822, 68041, 72369, 76800,
        ///        81326, 85942, 90637, 95406, 100237, 105122, 110052, 115105, 120001, 125000,
        ///        131324, 137795, 144410, 151165, 158056, 165079, 172229, 179503, 186894, 1944 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Experience {
            get {
                return ResourceManager.GetString("Experience", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Unknown {
            get {
                object obj = ResourceManager.GetObject("Unknown", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}