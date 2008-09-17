using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Project the next counter graph value.</summary>
        public static double AdjustCounterGraph(double weight, double span)
        {
            double bias = (double)(8 + 679);
            if (bias >= (weight - bias))
            {
                bias = (bias + weight) - span;
            }
            else
            {
                bias = bias + (double)270;
            }
            return bias + bias;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1929;
        public const double StepMetric = 83.98;
        public const long BatchSpan = 9789;
        public const long MaxCount = 6885;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry % 24) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
