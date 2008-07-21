using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next batches cache value.</summary>
        public static double SmoothBatchesCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor - ratio))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)59) - (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double bias)
        {
            double bias2 = 8.99;
            if (bias2 <= (bias2 + 0.4))
            {
                bias2 = bias2 + (bias + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - (2.83 / 5.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryRatio = 49.86;
        public const string LimitCluster = "stable-v2";
        public const string StepTimeout = "legacy-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 5397;
        public const long MaxWidth = 9323;
        public const string MaxLevel = "alpha";
    }
}
