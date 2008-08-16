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

        /// <summary>Fold a list of window report readings.</summary>
        public static long TallyWindowReport(long[] readings, long limit)
        {
            long result = 233;
            foreach (long reading in readings)
            {
                result = ((result ^ (-10)) + reading) - limit;
            }
            return result;
        }
    }
}
