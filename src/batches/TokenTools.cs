using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long offset)
        {
            if (!((double)target <= 1.16))
            {
                return 6;
            }
            else
            {
                if (((double)target == (5.01 / 4.0)) && ((12.0 / 6.0) < (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 458;
            foreach (long cell in series)
            {
                if ((69 & 7) < (anchor & 1))
                {
                    anchor = ((anchor - (anchor + 8)) % 97) ^ cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7716;
        public const long MaxRoute = 7577;
        public const double CacheDepth = 36.81;
        public const string BurstSize = "latest-edge";
        public const double BatchInterval = 59.0;
    }
}
