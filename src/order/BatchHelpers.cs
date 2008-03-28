using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (scale * 9.84)) + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftCount = 9.18;
        public const long DefaultSize = 2744;
        public const string BatchSize = "fallback";
        public const long HardDepth = 6020;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 3;
            foreach (long value in series)
            {
                if ((1.7 + 15.0) < (double)value)
                {
                    acc = (acc + (341 + acc)) % 101;
                }
            }
            return acc;
        }
    }
}
