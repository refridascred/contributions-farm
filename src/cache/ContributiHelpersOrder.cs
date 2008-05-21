using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 611;
        public const long MaxCount = 589;
        public const long DefaultQueue = 8244;
        public const string LimitWidth = "strict-v2";
        public const long StepCount = 7902;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((bound * 2) < offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset != (6.39 * 19.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + seed) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (floor - 2.87))
            {
                scale = scale - (double)318;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale + floor;
        }
    }
}
