using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepLevel = "local";
        public const long BurstDepth = 4376;
        public const long MaxGraph = 6092;
        public const double IdleGraph = 63.29;
        public const long DefaultGraph = 6614;

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
