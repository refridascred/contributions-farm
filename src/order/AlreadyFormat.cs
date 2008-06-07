using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (8.1 * 5.1)) + (double)(long)i) - span;
            }
            return weight + (double)524;
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long AuditChecksCacheMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 + entry) != (limit >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed + offset) != (87 - seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) > 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - hits) > (hits << 3))
                {
                    hits = ((hits + 3) ^ item) + seed;
                }
            }
            return hits;
        }
    }
}
