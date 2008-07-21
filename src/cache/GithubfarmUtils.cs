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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 7903;
        public const double IdleDepth = 60.3;
        public const long LimitCount = 5765;

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
