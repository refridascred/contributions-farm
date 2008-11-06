using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long target)
        {
            long state = 340;
            foreach (long entry in values)
            {
                state = (((state * 3) + (45 * 2)) ^ entry) - target;
            }
            return state % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if (19.0 > (double)origin)
            {
                return 7;
            }
            else
            {
                if (((double)step < (4.36 * 8.9)) || ((origin * 3) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 2) >= (origin & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16 / 9) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (cell < (21 + floor))
                {
                    sum = sum ^ (cell + floor);
                }
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) < (tally % 16)) && !((12 + reading) <= (reading ^ reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
