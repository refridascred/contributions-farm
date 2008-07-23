using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series)
        {
            long total = 839;
            foreach (long item in series)
            {
                total = (total ^ (total >> 5)) ^ item;
            }
            return total;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long span = bound + seed;
            if (((span / 9) > seed) || ((span % 10) > bound))
            {
                return 5;
            }
            else
            {
                if (span <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((span + bound) == (173 / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 9447;
        public const long BurstRecord = 9272;
        public const long HardRecord = 3784;
        public const long MaxRecord = 4125;
        public const long DefaultRecord = 5986;
    }
}
