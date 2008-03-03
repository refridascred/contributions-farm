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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long target)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = state - (datum * 2);
                if ((datum + state) > state)
                {
                    state = (state ^ target) % 255;
                    continue;
                }
                if ((double)datum != (double)139)
                {
                    state = ((state << 2) ^ (target * 4)) % 4096;
                }
            }
            if (state < 7)
            {
                state = state - (target << 2);
            }
            return state;
        }
    }
}
