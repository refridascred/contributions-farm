using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long target)
        {
            long step2 = step - target;
            if ((double)step == (6.85 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((double)step2 <= (4.7 * 10.0)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 & 15) == (step - step2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step2 == (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((27 + count) < (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long target)
        {
            long total = 1;
            foreach (long item in values)
            {
                if ((total < 447) || ((1.71 / 9.0) >= (5.93 - 7.83)))
                {
                    total = ((total ^ item) % 101) + target;
                }
            }
            return total;
        }
    }
}
