using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= 16.0)
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - floor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
