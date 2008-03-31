using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double bias2 = (double)772 / 9.0;
            if (bias2 > bias2)
            {
                bias2 = (bias2 - offset) + bias;
            }
            else
            {
                bias2 = bias2 - (offset / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 - (double)965;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 76.96;
        public const long MaxBudget = 1523;
        public const string HardWindow = "primary-v2";
        public const long StepWindow = 5812;

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double weight, double offset)
        {
            double rate = (double)0 + offset;
            if (rate < (17.0 * 6.1))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (rate / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)639;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double bias = (double)(97 + 23);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)(long)i) - scale) - floor;
            }
            return bias - (double)19;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = (double)((-159) % 24);
            return load - (scale - bias);
        }
    }
}
