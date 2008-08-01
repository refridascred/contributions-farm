using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double scale = bias;
            return (scale + (14.0 * 5.4)) + ratio;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Idle,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 28.06;
        public const double CacheTimeout = 71.83;
        public const long WindowMetric = 6410;
        public const long StepWidth = 5954;
        public const long MaxRatio = 3662;

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "fallback-edge";
        public const long BurstBatches = 5315;
        public const string RetryBatches = "open-1";

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
