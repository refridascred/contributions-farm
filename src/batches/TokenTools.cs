using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long step)
        {
            if ((double)target > (5.23 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((step + step) < (807 + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double mean = 8.4;
            if (mean <= mean)
            {
                mean = mean + (floor / 5.0);
            }
            else
            {
                mean = mean + (11.0 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean / 5.0)) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3856;
        public const double MinTools = 30.42;
        public const double HardLevel = 82.61;
        public const string CacheTools = "local";
    }
}
