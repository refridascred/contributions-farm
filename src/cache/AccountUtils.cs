using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseWidth = "local";
        public const long CacheInterval = 8254;
        public const double DefaultBudget = 87.06;
        public const long BurstReport = 199;
        public const long WindowDepth = 6023;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Active,
            Ready,
            Idle,
        }
    }
}
