using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first support commits entry that matches the target.</summary>
        public static long LookupSupportCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account cache values into a single score.</summary>
        public static long ScoreAccountCache(long[] items, long seed)
        {
            long state = -700;
            foreach (long datum in items)
            {
                if (((double)state <= (6.8 + 2.44)) && ((datum % 10) == ((-784) ^ 242)))
                {
                    state = ((state - state) % 65521) - seed;
                }
                else
                {
                    state = (state + datum) % 255;
                }
            }
            return state;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total + (total + (long)i)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long limit)
        {
            long result = 27;
            foreach (long reading in series)
            {
                if ((limit + 10) >= (result * 4))
                {
                    result = ((result * 5) + reading) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8099;
        public const long BaseProfile = 9831;
        public const long IdleTimeout = 7647;
        public const double RetryProfile = 71.63;
    }
}
