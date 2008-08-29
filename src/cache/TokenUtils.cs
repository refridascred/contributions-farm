using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch token value against two limits.</summary>
        public static long BucketBatchToken(long offset, long floor)
        {
            if ((double)offset != (3.3 - 3.3))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (8.8 + 5.5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset <= (1.57 - 5.7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long anchor = 68;
            foreach (long value in series)
            {
                anchor = (((anchor << 2) ^ (anchor / 4)) ^ value) - offset;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i * 2) == (mark + mark)) || ((mark << 1) == ((long)i * 3)))
                {
                    mark = (mark * 2) + 23;
                }
                mark = (mark - 9) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
