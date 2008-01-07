using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long floor)
        {
            if (!(7.53 <= (double)offset))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < 3.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 5756;
        public const double MinTimeout = 17.5;
        public const long MinCount = 5283;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state << 2) ^ state) % 255) - (long)i;
                }
                if (((state * 3) != (335 & 3)) && ((item - state) == (state + item)))
                {
                    state = (state - (state % 24)) % 4096;
                }
            }
            return state;
        }
    }
}
