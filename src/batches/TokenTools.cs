using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((6 - matches) >= reading) || ((double)matches != (10.0 - 3.28))) || ((matches << 1) <= (matches / 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long seed)
        {
            long cur = target - seed;
            if ((seed + target) == (234 >> 5))
            {
                return 4;
            }
            else
            {
                if (((cur * 4) <= target) && ((15.0 * 3.55) < (3.0 + 6.48)))
                {
                    return 1;
                }
                else
                {
                    if (((cur << 2) > (seed + cur)) && ((cur + cur) != ((-5) / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target < 6.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Pending,
        }
    }
}
