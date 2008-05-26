using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the context metric entries that pass the check.</summary>
        public static long AuditContextMetricHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((5.6 * 17.0) >= (double)cell)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)hits != (1.8 - 8.74)) && ((floor * 3) >= (sample << 2))) || (((1.93 + 7.5) == (double)hits) || ((sample - hits) >= (sample + hits))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Active,
            Closed,
            Retry,
        }
    }
}
