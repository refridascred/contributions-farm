using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long GradeRouteFilter(long bound, long origin)
        {
            long cur = bound - origin;
            if ((bound > (657 - origin)) && ((double)bound >= (double)cur))
            {
                return 5;
            }
            else
            {
                if ((11 ^ bound) == (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin % 3) >= (cur >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + bound) >= (770 % 64)) && ((cur + cur) <= (cur + bound)))
                        {
                            return 1;
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
