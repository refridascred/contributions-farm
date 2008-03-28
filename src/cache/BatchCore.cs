using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double bias2 = 9.0;
            if (bias2 >= (scale - scale))
            {
                bias2 = bias2 - (scale * 6.6);
            }
            return bias2 + bias;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum - matches) < (step & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache context value against two limits.</summary>
        public static long SortCacheContext(long floor, long seed)
        {
            if (((double)seed != (4.94 / 2.0)) || (((-6) ^ seed) >= floor))
            {
                return 2;
            }
            else
            {
                if (((floor / 6) <= (seed + 22)) && ((seed >> 4) < (seed >> 3)))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 63) == (floor % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5197;
        public const long IdleRatio = 9837;
        public const long LimitRatio = 3328;
    }
}
