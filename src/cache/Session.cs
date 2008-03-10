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

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Synced,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 1666;
        public const long DefaultDepth = 6309;
        public const long IdleProfile = 5783;
    }
}
