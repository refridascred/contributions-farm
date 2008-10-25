using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9303;
        public const long RetryGraph = 3385;
        public const long CacheGraph = 4520;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
