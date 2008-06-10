using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 5117;
        public const long MaxFormat = 1760;
        public const string IdleFormat = "primary";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long floor)
        {
            long cur = seed + floor;
            if ((cur << 3) == (cur * 3))
            {
                return 8;
            }
            else
            {
                if ((6.89 + 13.0) != (double)cur)
                {
                    return 1;
                }
                else
                {
                    if (((cur << 1) > 68) && (966 < (seed << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur * 2) <= (floor + cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Dropped,
            Closed,
            Draft,
            Locked,
        }
    }
}
