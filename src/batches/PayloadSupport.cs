using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings)
        {
            long mix = 5;
            foreach (long entry in readings)
            {
                mix = (((mix * 4) + (mix + 366)) % 101) ^ entry;
            }
            return mix;
        }

        /// <summary>Project the next cache buffer value.</summary>
        public static double AdjustCacheBuffer(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > bias2)
            {
                bias3 = bias3 + (20.0 + bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - (bias / 3.0)) + (double)(long)i;
            }
            return bias3 + 1.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.49;
        public const long BaseInterval = 9401;
        public const double BurstChannel = 82.49;
        public const double BatchChannel = 38.07;
        public const double MaxChannel = 97.9;
    }
}
