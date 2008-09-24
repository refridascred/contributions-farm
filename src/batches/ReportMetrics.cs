using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4584;
        public const long BurstLayout = 3546;
        public const double HardBudget = 95.4;
        public const long LimitLayout = 9957;
        public const long CacheLayout = 8404;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Paused,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long total = 40;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum ^ datum)) % 101;
            }
            return total;
        }
    }
}
