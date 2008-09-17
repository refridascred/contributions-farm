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

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (ratio * 1.9))
            {
                ratio = ratio + (weight * 7.8);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)88) + (double)(long)i;
            }
            return ratio - (bias * 9.49);
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
