using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cache tools counter forward.</summary>
        public static long DeriveCacheTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((next & 15) == (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((15.0 / 7.0) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - origin) <= origin)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 6413;
        public const string BurstRatio = "strict-v2";
        public const long RetryMetrics = 1465;
        public const long MinMetrics = 5436;
    }
}
