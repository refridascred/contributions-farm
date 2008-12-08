using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a metric context reading by value.</summary>
        public static long LocateMetricContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < 2.36)
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = (double)(83 % 100);
            return ((load - load) + ratio) + span;
        }
    }
}
