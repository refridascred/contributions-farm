using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 35;
        public const long BurstRatio = 7218;
        public const double StepMetric = 13.07;
        public const double MaxWidth = 64.52;
        public const long DefaultBudget = 3247;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Active,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series)
        {
            long carry = 88;
            foreach (long entry in series)
            {
                carry = (carry - carry) + entry;
            }
            return carry % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "cached-edge";
        public const string BaseRecord = "cached-1";
        public const long SoftScore = 5428;
        public const long LimitRatio = 9109;
        public const string DefaultRecord = "local-1";
    }
}
