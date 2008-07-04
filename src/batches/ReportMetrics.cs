using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (1.1 + 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
