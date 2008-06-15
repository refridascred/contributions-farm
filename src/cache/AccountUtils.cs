using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            New,
            Dropped,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultScore = 2374;
        public const long CacheDepth = 6305;
        public const long BurstCount = 6695;
        public const long BaseInterval = 2007;
        public const double SoftCommand = 74.48;
    }
}
