using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double drift = bias + bias;
            if (drift > (drift + floor))
            {
                drift = drift - (double)268;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 67.96;
        public const double WindowWidth = 24.64;
        public const long MinMetrics = 9380;
        public const long CacheLevel = 3296;
    }
}
