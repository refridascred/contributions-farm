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

        /// <summary>Look up the position of a cache already sample.</summary>
        public static long FindCacheAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (origin / 4))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
