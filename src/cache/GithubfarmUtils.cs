using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target ^ 785) <= (hits >> 4))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 3) ^ ((long)i + step)) % 255;
                acc = ((acc * 3) + (long)i) % 1000;
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
