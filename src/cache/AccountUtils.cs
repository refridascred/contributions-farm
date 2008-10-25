using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 33.29;
        public const long MaxRecord = 5063;
        public const double IdleLevel = 29.18;
        public const long IdleRecord = 6702;

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
