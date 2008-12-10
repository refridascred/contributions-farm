using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long TallyMetricsLayoutMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((bound - bound) != (tally >> 2)))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -974;
            foreach (long reading in data)
            {
                carry = ((carry - (carry ^ carry)) % 97) ^ reading;
            }
            return carry;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value < (target << 3)) || ((190 >> 2) >= target)) && ((double)value == (5.0 - 0.1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
