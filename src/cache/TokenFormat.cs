using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((double)563 != (double)target)
            {
                return 2;
            }
            else
            {
                if (bound < (target ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 24) > (69 / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long lane = target + origin;
            if ((double)origin != (0.06 / 3.0))
            {
                return 2;
            }
            else
            {
                if (origin >= (origin << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin - lane) < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((775 / 2) <= (lane % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
