using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long carry = 47;
            foreach (long reading in series)
            {
                carry = carry - ((-12) + reading);
                carry = (carry * 2) + (carry << 3);
                if ((reading & 3) != (carry / 6))
                {
                    break;
                }
            }
            if (carry < 532)
            {
                carry = ((carry * 4) + 750) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 475;
            foreach (long item in series)
            {
                state = (state ^ 166) % 101;
                if ((item % 100) != (item - item))
                {
                    state = (state + (378 + 997)) % 65521;
                }
                state = (state * 2) + (213 + item);
            }
            return state;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long target)
        {
            long mark = 9;
            foreach (long value in values)
            {
                mark = (((mark << 3) ^ (mark << 2)) % 101) + target;
                mark = (mark ^ ((long)values.Length / 8)) % 255;
                if ((2.6 + 4.9) != (double)value)
                {
                    mark = (mark * 3) + (value / 8);
                }
                else
                {
                    mark = ((mark * 5) + (value + value)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
