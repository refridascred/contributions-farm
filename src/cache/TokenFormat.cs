using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxWidth = "fallback-edge";
        public const long MinCommits = 3034;
        public const string WindowCommits = "cached-edge";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length == (9.0 - 9.88))
                {
                    hits = ((hits + 2) + reading) - seed;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)(-4) >= (double)reading)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
