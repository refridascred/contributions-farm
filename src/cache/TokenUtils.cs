using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double bias = 1.1;
            if (bias > offset)
            {
                bias = bias + 0.1;
            }
            else
            {
                bias = bias + (bias - offset);
            }
            return bias + (offset + scale);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (((double)edge > (double)floor) && ((double)edge >= (17.0 * 9.0)))
            {
                return 2;
            }
            else
            {
                if ((edge % 7) <= (46 % 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 5079;
        public const long IdleCommits = 4682;
        public const string BaseSpan = "latest-v2";
        public const long DefaultLevel = 102;
        public const long RetryCommits = 8786;
    }
}
