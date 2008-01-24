using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((double)step < (2.71 + 5.7))
            {
                return 7;
            }
            else
            {
                if ((230 ^ floor) > (step - 601))
                {
                    return 6;
                }
                else
                {
                    if ((floor + (-8)) < (step % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1 ^ floor) >= 104)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = (total ^ (total + 62)) - sample;
            }
            if (total > 1)
            {
                total = total + ((-33) % 10);
            }
            return total % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long floor)
        {
            long acc = 438;
            foreach (long sample in values)
            {
                acc = (acc - (4 * 2)) ^ sample;
            }
            if (acc < 342)
            {
                acc = (acc ^ floor) % 4096;
            }
            return acc;
        }
    }
}
