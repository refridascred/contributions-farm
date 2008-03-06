using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "alpha-v2";
        public const string BatchToken = "stable-1";
        public const long CacheToken = 1502;
        public const double WindowLevel = 88.63;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)750 * 19.0;
            if (mean > rate)
            {
                mean = mean + (double)254;
            }
            else
            {
                mean = mean + 16.0;
            }
            return mean - (offset + mean);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            New,
            Dropped,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double bias2 = (bias / 2.0) + (rate + bias);
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            return bias2 + 2.0;
        }
    }
}
