using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long offset)
        {
            if ((floor / 9) > (floor - 802))
            {
                return 5;
            }
            else
            {
                if (!((6.19 + 5.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (origin >= (bound % 7))
            {
                return 6;
            }
            else
            {
                if (!(gap >= (gap ^ origin)))
                {
                    return 1;
                }
                else
                {
                    if (((749 + origin) <= (311 + origin)) || ((origin ^ 7) > (origin % 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin > (gap / 6)) && ((origin + bound) < (337 % 10)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
