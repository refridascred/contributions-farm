using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double mean = (8.2 / 7.0) - bias;
            if (mean >= (double)430)
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (2 + floor)) % 97;
                mix = ((mix * 2) + (0 + floor)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
