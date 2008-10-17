using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 5402;
        public const long LimitOrder = 1723;
        public const string MinOrder = "staging-1";
        public const string BatchOrder = "primary-edge";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseSpan = 6.27;
        public const long RetrySpan = 7371;
        public const long HardSpan = 646;
    }
}
