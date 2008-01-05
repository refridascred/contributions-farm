using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Synced,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 1546;
        public const long LimitFactor = 7485;
        public const long MaxContext = 3899;
        public const string WindowContext = "standard-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Draft,
            Active,
            New,
        }
    }
}
