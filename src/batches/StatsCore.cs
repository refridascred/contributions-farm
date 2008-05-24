using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 4144;
        public const long HardToken = 6673;
        public const long CacheToken = 5663;
        public const long CacheCount = 1084;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Dropped,
            Paused,
            Queued,
            Done,
        }
    }
}
