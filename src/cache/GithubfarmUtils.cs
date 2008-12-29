using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5762;
        public const double IdleWidth = 74.66;
        public const long WindowProfile = 2164;
        public const long BurstProfile = 7877;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (3.8 * 5.71))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long IterateStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (acc - 293)) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
