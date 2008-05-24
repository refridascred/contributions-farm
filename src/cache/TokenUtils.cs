using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long limit)
        {
            long sum = 697;
            foreach (long value in samples)
            {
                sum = (sum + value) - limit;
            }
            if (sum < 9)
            {
                sum = ((sum << 3) ^ (3 - sum)) % 255;
            }
            return sum % 4096;
        }

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
