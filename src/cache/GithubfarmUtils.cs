using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool CheckEntryClusterRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (value - value))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + (bound - bound)) % 101) ^ (long)i2;
                    mix = (mix - (mix / 2)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryInterval = 20;
        public const long SoftCount = 3672;
        public const double IdleRatio = 39.08;
        public const long BatchToken = 5898;
        public const double SoftWidth = 34.13;
    }
}
