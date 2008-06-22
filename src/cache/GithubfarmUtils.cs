using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 53.95;
        public const double IdleLevel = 50.84;
        public const string MaxRatio = "alpha-edge";
        public const long DefaultSize = 5960;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!(((seed - 2) <= (seed >> 2)) && ((seed << 2) >= sum)))
                {
                    sum = ((sum * 4) + (sum * 2)) % 4096;
                }
                sum = (sum << 2) ^ (seed >> 4);
                if ((seed >> 5) == (sum / 4))
                {
                    sum = ((sum << 2) ^ ((long)i + seed)) % 4096;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
