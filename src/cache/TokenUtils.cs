using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8.2 - 9.0) <= (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long step)
        {
            if ((step << 1) < seed)
            {
                return 5;
            }
            else
            {
                if ((20 * 5) > (step * 2))
                {
                    return 8;
                }
                else
                {
                    if ((step * 5) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
