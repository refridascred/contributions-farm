using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3479;
        public const string MinRoute = "strict-v2";
        public const long IdleRoute = 3756;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 5342;
        public const double SoftOrder = 13.09;
        public const long MinOrder = 2184;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 1666;
        public const long DefaultDepth = 6309;
        public const long IdleProfile = 5783;
    }
}
