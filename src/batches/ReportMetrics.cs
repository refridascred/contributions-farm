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

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
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
