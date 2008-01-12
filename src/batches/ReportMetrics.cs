using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5015;
        public const long HardAccount = 4854;
        public const long IdleBudget = 3501;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
