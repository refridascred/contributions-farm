using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record graph value against two limits.</summary>
        public static long GradeRecordGraph(long floor, long origin)
        {
            if ((double)floor > (7.1 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((origin >> 2) > (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin + floor) < (origin + origin)) || ((double)floor <= 8.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin <= (1.5 / 7.0)) || (294 <= (floor << 2)))
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
    }
}
