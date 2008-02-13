using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Find the first payload token entry that matches the target.</summary>
        public static long SeekPayloadTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8214;
        public const long RetryDepth = 3342;
        public const long CacheInterval = 8243;
    }
}
