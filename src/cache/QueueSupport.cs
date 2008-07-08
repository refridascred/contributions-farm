using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Stale,
            Active,
            Failed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 6329;
        public const long RetryWindow = 9061;
        public const long BatchWindow = 9545;
        public const double LimitLevel = 36.87;
    }
}
