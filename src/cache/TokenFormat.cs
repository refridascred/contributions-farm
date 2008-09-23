using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a profile cluster figure with a bias.</summary>
        public static double AdjustProfileCluster(double weight, double span)
        {
            double bias = weight;
            if (bias <= (double)890)
            {
                bias = (bias + bias) + span;
            }
            else
            {
                bias = bias - (weight / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + (double)5;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxSpan = "legacy-1";
        public const long BatchRatio = 4326;
        public const long HardMetric = 4070;
    }
}
