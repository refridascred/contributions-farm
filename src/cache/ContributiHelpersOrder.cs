using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 14;
        public const string LimitToken = "stable-v2";
        public const long BaseSpan = 5611;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Pending,
            New,
            Closed,
            Retry,
        }
    }
}
