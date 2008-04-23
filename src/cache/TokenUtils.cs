using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double span)
        {
            double bias = (double)(995 + 4);
            for (int i = 0; i < 2; i++)
            {
                bias = (((bias - (bias * 11.0)) + (double)(long)i) + gain) - span;
            }
            return bias + (double)81;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-1";
        public const long LimitCount = 3997;
        public const double RetryBatch = 27.28;
        public const long SoftScore = 6088;
    }
}
