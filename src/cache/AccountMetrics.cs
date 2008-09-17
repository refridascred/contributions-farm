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

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
