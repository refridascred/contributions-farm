using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Look up the position of a profile stream sample.</summary>
        public static long FindProfileStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Active,
            Locked,
            Synced,
        }
    }
}
