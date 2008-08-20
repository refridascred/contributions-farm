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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) <= (sample ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
