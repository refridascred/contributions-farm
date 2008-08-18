using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-edge";
        public const long LimitFactor = 1636;
        public const long CacheChannel = 5273;
        public const long RetryChannel = 4513;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > (double)6)
            {
                bias2 = bias2 - (bias2 + bias);
            }
            else
            {
                bias2 = bias2 + 2.6;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias + bias2)) + (double)(long)i;
            }
            return bias2 + (bias2 - bias2);
        }
    }
}
