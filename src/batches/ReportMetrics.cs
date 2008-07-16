using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)(-5) >= (double)item))
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long target)
        {
            if ((86 - target) < (offset - target))
            {
                return 4;
            }
            else
            {
                if (((target >> 2) > (target % 12)) || ((double)target >= (11.0 * 17.0)))
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) <= (target & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values, long limit)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if ((cell - (-8)) <= (12 + mark))
                {
                    mark = (mark ^ (cell & 15)) % 101;
                }
            }
            if (mark < 6)
            {
                mark = (mark * 5) + limit;
            }
            return mark;
        }
    }
}
