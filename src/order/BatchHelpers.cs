using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long acc = 804;
            foreach (long reading in series)
            {
                acc = ((acc - (531 >> 1)) % 255) - reading;
                acc = ((acc << 3) ^ (bound / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double gain = (double)476 * 4.3;
            if (gain > (double)806)
            {
                gain = ((gain + 16.0) + bias) - floor;
            }
            else
            {
                gain = gain + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 9.1) - (double)(long)i;
            }
            return gain - (double)287;
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
