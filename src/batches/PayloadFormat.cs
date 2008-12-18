using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double load = weight;
            if (load <= 1.3)
            {
                load = (load - (8.0 * 1.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load - (weight / 5.0);
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 38;
            foreach (long item in items)
            {
                if (item >= (item / 7))
                {
                    sum = (sum - (12 ^ (-273))) % 255;
                }
                else
                {
                    sum = (sum - (item / 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinLevel = 28.44;
        public const long HardRatio = 6885;
        public const double MaxSize = 71.1;
        public const long BatchTimeout = 9062;
        public const long DefaultQueue = 6852;
    }
}
