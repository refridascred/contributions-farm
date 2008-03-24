using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 15) < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools contributi value against two limits.</summary>
        public static long GradeToolsContributi(long offset, long seed)
        {
            long lane = offset ^ seed;
            if (!(offset <= (lane - seed)))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (2.6 + 9.27))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 4) < 625)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.0 - 1.87) >= (double)lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((floor ^ 6) <= count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
