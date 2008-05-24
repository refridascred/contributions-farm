using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                double load = 15.0;
                if (load >= (14.0 * 6.15))
                {
                    continue;
                }
                if (!((1.78 * 3.5) == (double)anchor))
                {
                    anchor = (((anchor * 2) + (8 + 7)) - item) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchWidth = 1552;
        public const double IdleRatio = 88.62;
        public const long CacheLevel = 7171;
        public const double RetryTools = 76.26;
        public const double BurstTools = 23.69;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long floor)
        {
            if (((floor * 2) < (seed + floor)) && (floor >= (floor * 4)))
            {
                return 8;
            }
            else
            {
                if (floor > (seed >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((25 >> 5) < (seed + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + floor) >= (20 + 20))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
