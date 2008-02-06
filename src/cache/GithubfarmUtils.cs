using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long score = 577;
            foreach (long reading in levels)
            {
                score = (score ^ origin) % 65521;
                if (reading > (reading % 7))
                {
                    break;
                }
            }
            if (score < 92)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 9508;
        public const long SoftStream = 7345;
        public const long CacheFactor = 4414;
        public const long MaxStream = 4547;
        public const long IdleLevel = 5255;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + target;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (double)106)
            {
                ratio = ratio + (rate / 2.0);
            }
            else
            {
                ratio = ratio + (rate - ratio);
            }
            return ratio - rate;
        }
    }
}
