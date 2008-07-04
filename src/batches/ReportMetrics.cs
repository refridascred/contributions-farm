using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstFactor = 9.77;
        public const long LimitEditor = 2352;
        public const double StepScore = 23.45;
        public const long CacheEditor = 5035;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Retry,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count * 5) <= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
