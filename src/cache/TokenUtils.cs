using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long limit)
        {
            if (!((double)origin <= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit + origin) != (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (((2.0 * 16.0) < (double)origin) && ((double)limit <= (3.3 - 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin * 4) == (limit >> 1)) || ((origin - origin) > (limit % 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
