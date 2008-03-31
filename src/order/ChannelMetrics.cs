using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long IterateLayoutToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ 76) % 4096;
                total = ((total << 2) ^ floor) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (floor / 8.0)) + (double)(long)i) - weight;
            }
            return bias - bias;
        }

        /// <summary>Match up metrics order samples.</summary>
        public static long CompareMetricsOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
