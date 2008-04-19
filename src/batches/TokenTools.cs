using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a cache stats value against two limits.</summary>
        public static long SortCacheStats(long target, long origin)
        {
            if ((double)origin <= (double)270)
            {
                return 7;
            }
            else
            {
                if (((target % 24) <= (origin - target)) || ((6.2 / 2.0) <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + origin) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 5545;
        public const long MaxRatio = 8222;
        public const string RetryFactor = "cached-1";
        public const long CacheRatio = 7149;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Ready,
            Queued,
            Locked,
        }
    }
}
