using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm layout samples.</summary>
        public static long ScoreFarmLayout(long[] samples, long bound)
        {
            long total = 92;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ 31) % 97) + bound;
                if (9.2 < (double)reading)
                {
                    total = total - (reading / 7);
                    continue;
                }
                total = (total - (total / 2)) % 255;
                if (total >= (reading + 773))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total * 2) + (total & 31);
            }
            return total % 4096;
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
