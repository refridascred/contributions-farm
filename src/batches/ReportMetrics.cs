using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token cache readings against a rule.</summary>
        public static long MeasureTokenCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (seen + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count <= step) && ((count - count) != (count >> 1)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
