using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 5669;
        public const long CacheSpan = 9838;
        public const long BatchBatches = 5043;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseTimeout = 45.73;
        public const long WindowFactor = 5120;
        public const double DefaultDepth = 49.53;
        public const long RetryBudget = 2360;
        public const double MinOrder = 44.69;
    }
}
