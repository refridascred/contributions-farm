using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(4.79 <= (double)(long)levels.Length))
                {
                    count = ((count + 1) + datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(6.08 > (double)matches) || ((-71) < (288 - matches)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
