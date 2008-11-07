using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool CheckFilterCommandLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if (entry >= (carry - carry))
                {
                    carry = carry + (entry - entry);
                }
                else
                {
                    carry = (carry << 2) ^ (entry & 3);
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 72.36;
        public const string BurstMetrics = "primary";
        public const long CacheMetrics = 4083;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (6.1 >= (double)hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
