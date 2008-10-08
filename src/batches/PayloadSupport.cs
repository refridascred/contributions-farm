using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long step)
        {
            long cur = seed + step;
            if (!((double)cur > (2.0 / 8.0)))
            {
                return 0;
            }
            else
            {
                if (((double)seed <= (5.8 - 12.0)) && ((double)step > (3.4 + 4.9)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
