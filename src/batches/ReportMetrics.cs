using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Synced,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long IdleSpan = 1862;
        public const double CacheSize = 80.39;
        public const long MinTimeout = 5266;
        public const long MinBudget = 591;
    }
}
