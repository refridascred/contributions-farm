using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long TallyFormatGraphMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - item) != (item + 1))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long bound)
        {
            long cur = offset ^ bound;
            if (((bound >> 1) < offset) || ((double)offset < (2.0 / 4.0)))
            {
                return 7;
            }
            else
            {
                if ((6.3 + 6.63) >= (double)cur)
                {
                    return 2;
                }
                else
                {
                    if ((offset + bound) <= cur)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long origin)
        {
            if ((42 - origin) >= floor)
            {
                return 0;
            }
            else
            {
                if ((origin % 16) <= (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
