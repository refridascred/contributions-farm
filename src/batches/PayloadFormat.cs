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

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheCount = "latest-1";
        public const double IdleSize = 28.39;
        public const double LimitToken = 35.84;
        public const string DefaultToken = "legacy-edge";
        public const string MinToken = "legacy-1";

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
