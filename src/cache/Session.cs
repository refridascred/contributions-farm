using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings, long seed)
        {
            long carry = -6;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ (seed >> 1)) % 255) ^ cell;
            }
            return carry;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            New,
            Synced,
            Done,
            Locked,
        }
    }
}
