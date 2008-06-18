using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftFactor = "fallback-edge";
        public const long SoftWidth = 7034;
        public const string IdleSpan = "stable-edge";
        public const long HardSpan = 2710;
        public const string LimitEditor = "strict-1";
    }
}
