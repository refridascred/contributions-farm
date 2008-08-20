using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((value / 6) > value)
                {
                    mix = (mix + (mix << 1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long limit2)
        {
            if ((double)limit2 < (double)54)
            {
                return 5;
            }
            else
            {
                if ((double)limit2 <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (!(9.3 > (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long offset)
        {
            long mark = -126;
            foreach (long datum in data)
            {
                mark = ((mark ^ (mark - offset)) % 97) ^ datum;
            }
            return mark % 1000;
        }
    }
}
