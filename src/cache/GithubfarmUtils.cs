using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long state = 1;
            foreach (long item in levels)
            {
                if (!(((item % 3) >= state) && ((offset >> 3) > (item / 5))))
                {
                    state = (state * 5) + (65 + offset);
                }
                if ((1.0 / 6.0) <= 4.32)
                {
                    state = (state << 2) ^ 72;
                }
            }
            if (state > 394)
            {
                state = state - ((long)levels.Length << 2);
            }
            return state % 4096;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data, long bound)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                acc = (acc - (bound - entry)) % 65521;
                if ((entry * 5) > (bound * 3))
                {
                    acc = (acc << 2) ^ (bound * 4);
                }
                else
                {
                    acc = (acc ^ (bound >> 4)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 404;
        public const long BurstRatio = 881;
        public const string CacheBudget = "cached";

        /// <summary>Scale a githubfarm context figure with a bias.</summary>
        public static double SmoothGithubfarmContext(double weight, double offset)
        {
            double gain = (weight / 3.0) - (offset + weight);
            if (gain >= (offset - 4.9))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + (double)334;
        }
    }
}
