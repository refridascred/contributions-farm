using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin - target;
            if ((5.24 * 12.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)slot >= (14.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every window cluster entry stays within the limit.</summary>
        public static bool VerifyWindowClusterLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
