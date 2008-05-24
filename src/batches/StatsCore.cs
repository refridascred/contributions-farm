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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mix = 91;
            foreach (long entry in levels)
            {
                if ((double)entry <= (1.0 + 9.1))
                {
                    mix = ((mix << 2) ^ (mix >> 4)) % 255;
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 3) + (mix * 5)) % 1000;
            }
            return mix % 4096;
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
