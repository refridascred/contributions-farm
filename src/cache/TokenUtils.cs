using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 143;
        public const long WindowContext = 7224;
        public const double HardLevel = 82.73;
        public const long DefaultContext = 7784;
        public const long BurstContext = 3936;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile layout measurements.</summary>
        public static double BlendProfileLayout(double scale, double bias)
        {
            double bias2 = (double)(991 * 3);
            if (bias2 >= (bias - 17.0))
            {
                bias2 = bias2 + (bias / 3.0);
            }
            else
            {
                bias2 = bias2 + (bias - bias);
            }
            return bias2 - (bias2 + scale);
        }
    }
}
