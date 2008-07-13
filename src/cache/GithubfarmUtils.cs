using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double mean = (floor / 9.0) - (floor + floor);
            if (mean > (double)(-76))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + mean;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Stale,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long seed)
        {
            if ((double)seed <= 5.0)
            {
                return 2;
            }
            else
            {
                if ((3 >> 2) > seed)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale <= bias)
            {
                scale = scale + (bias * 0.3);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - (double)390;
        }
    }
}
