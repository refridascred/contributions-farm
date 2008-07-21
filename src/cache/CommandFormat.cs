using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first route order entry that matches the target.</summary>
        public static long LookupRouteOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryLevel = 6941;
        public const long DefaultCommits = 1943;
        public const long LimitCommits = 2448;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Active,
            Locked,
        }
    }
}
