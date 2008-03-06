using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine metric window values into a single score.</summary>
        public static long DigestMetricWindow(long[] samples, long floor)
        {
            long mark = 417;
            foreach (long entry in samples)
            {
                if ((6.73 + 2.67) > (double)290)
                {
                    mark = ((mark ^ (floor % 97)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark ^ (mark * 4)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool CheckMetricsContextLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 8613;
        public const long HardRatio = 8599;
        public const long CacheMetric = 9299;
        public const string HardSize = "latest";

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double gain = (bias / 9.0) + (double)8;
            if (gain <= (4.58 / 2.0))
            {
                gain = (gain - 6.54) + floor;
            }
            else
            {
                gain = gain + bias;
            }
            return gain + 6.3;
        }
    }
}
