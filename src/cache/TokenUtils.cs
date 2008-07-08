using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSpan = 97.36;
        public const double RetryBatch = 31.58;
        public const long SoftBatch = 1993;
        public const long BurstRatio = 2089;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double gain = (double)52 + (ratio + floor);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio - ratio)) + (double)(long)i;
            }
            return gain + (double)(-8);
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double rate = span + (double)6;
            return (rate + (double)(-55)) + weight;
        }
    }
}
