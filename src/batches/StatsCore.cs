using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a batches format figure with a bias.</summary>
        public static double ScaleBatchesFormat(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (2.0 * 7.7)) + (double)(long)i) + gain;
            }
            return drift - drift;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryRatio = 97.37;
        public const long BurstLevel = 912;
        public const long LimitInterval = 7674;
        public const string CacheInterval = "standard-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseRatio = 92.06;
        public const long MaxCache = 4363;
        public const long RetryCount = 7589;
        public const long IdleCache = 3779;
        public const double StepCache = 93.91;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (scale / 6.0)) + (double)(long)i;
            }
            return bias2 + 4.0;
        }
    }
}
