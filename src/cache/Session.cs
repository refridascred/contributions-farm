using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor << 2) >= 53)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) < (729 & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin / 4)) || ((floor + origin) >= (floor ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark * 5)) % 1000;
                if ((double)bound < (double)mark)
                {
                    long diff2 = mark;
                    mark = (mark + (mark - diff2)) % 97;
                }
                else
                {
                    mark = mark ^ (bound + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1705;
        public const long SoftRecord = 5856;
        public const long HardRatio = 8041;
    }
}
