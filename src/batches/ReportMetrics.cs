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

        /// <summary>Audit command support readings against a rule.</summary>
        public static long CountCommandSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen < (value / 3)) || ((seen + (long)items.Length) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long IdleSpan = 1862;
        public const double CacheSize = 80.39;
        public const long MinTimeout = 5266;
        public const long MinBudget = 591;
    }
}
