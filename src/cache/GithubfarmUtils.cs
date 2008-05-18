using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) > ((-351) % 60))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            if (!((floor2 - floor) > (floor >> 4)))
            {
                return 3;
            }
            else
            {
                if (((5.1 * 7.0) < (double)floor) && ((floor2 + 79) >= floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((datum + datum) < 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
