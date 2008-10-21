using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
