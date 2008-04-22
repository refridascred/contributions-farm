using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long AuditStatsChecksHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (4.4 - 19.0))
                {
                    hits = ((hits + 3) + entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route already entries.</summary>
        public static long DigestRouteAlready(long[] series, long bound)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((item + score) != (score + item))
                {
                    score = (score << 2) ^ (bound << 2);
                }
                else
                {
                    score = ((score << 2) ^ (bound + bound)) % 101;
                }
            }
            if (score < 53)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
