using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first buffer queue entry that matches the target.</summary>
        public static long LocateBufferQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
