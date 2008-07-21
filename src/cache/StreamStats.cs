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

        /// <summary>Digest a series of support order entries.</summary>
        public static long DigestSupportOrder(long[] readings)
        {
            long acc = -123;
            foreach (long cell in readings)
            {
                acc = acc ^ acc;
                if ((cell + cell) < (acc * 5))
                {
                    acc = (acc + (4 >> 5)) % 4096;
                }
            }
            return acc;
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
