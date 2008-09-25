using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long floor)
        {
            long step = bound - floor;
            if ((floor << 1) >= (floor - step))
            {
                return 7;
            }
            else
            {
                if (((step / 6) <= (6 ^ bound)) || (5.9 <= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 12) == (step % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - 238) > (bound - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (2.56 > (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items)
        {
            long total = 235;
            foreach (long cell in items)
            {
                total = total + (total + total);
                if (((-43) + cell) <= ((long)items.Length % 60))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
