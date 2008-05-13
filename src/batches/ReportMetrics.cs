using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Closed,
            Paused,
            New,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 87.99;
        public const double CacheRecord = 98.06;
        public const long BaseLevel = 6516;
        public const string StepRecord = "alpha-1";
        public const long DefaultSpan = 9827;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
