using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample & 1) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double ratio = (floor * 2.63) / 6.0;
            if (ratio <= (9.09 / 2.0))
            {
                ratio = (ratio + (double)980) - scale;
            }
            return ratio - floor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 36.53;
        public const long RetryAlready = 9819;
        public const long DefaultLevel = 9485;
    }
}
