using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (0 > (count >> 4))
                {
                    count = ((count + 3) + reading) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long floor)
        {
            long span = target ^ floor;
            if (floor > 90)
            {
                return 4;
            }
            else
            {
                if ((target - floor) > (span >> 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
