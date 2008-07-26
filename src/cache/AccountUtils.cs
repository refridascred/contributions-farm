using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = (double)4;
            if (gain <= 1.4)
            {
                gain = gain + (double)660;
            }
            else
            {
                gain = gain - (offset + weight);
            }
            return gain + 0.14;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double bias = (2.3 - ratio) + ratio;
            if (bias < 7.1)
            {
                bias = bias + (floor - bias);
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - floor;
        }
    }
}
