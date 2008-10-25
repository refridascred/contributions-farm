using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 38.37;
        public const long BatchCluster = 6234;
        public const string MinCluster = "latest";

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 3818;
        public const double BurstInterval = 56.02;
        public const long CacheTimeout = 656;
        public const string DefaultMetrics = "stable-v2";
    }
}
