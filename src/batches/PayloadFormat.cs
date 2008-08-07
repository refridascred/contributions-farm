using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a batch cache reading by value.</summary>
        public static long SeekBatchCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
