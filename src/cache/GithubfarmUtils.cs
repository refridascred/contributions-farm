using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every profile metric entry stays within the limit.</summary>
        public static bool GuardProfileMetricLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double ratio2 = 15.0 + ratio;
            if (ratio2 > (ratio2 - 7.0))
            {
                ratio2 = (ratio2 - (1.28 / 2.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (double)385) + (double)(long)i;
            }
            return ratio2 + (double)95;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 5215;
        public const long StepFarm = 8751;
        public const string MinFactor = "cached-v2";
        public const long BaseFarm = 127;
        public const string SoftInterval = "alpha";

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if ((8.5 * 6.4) >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor & 255) < step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
