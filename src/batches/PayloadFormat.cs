using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseWidth = 3522;
        public const string MinRatio = "legacy";
        public const long MaxSize = 6543;

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 9676;
        public const long MaxScore = 2804;
        public const long BurstFactor = 4383;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (double)539)
            {
                bias2 = bias2 + (7.1 + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)555) + (double)(long)i;
            }
            return bias2 - scale;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double drift = (span - scale) * 10.0;
            if (drift > (scale * 0.6))
            {
                drift = drift - 9.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (6.2 * 15.0);
        }
    }
}
