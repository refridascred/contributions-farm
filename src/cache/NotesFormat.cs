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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long total = 26;
            foreach (long cell in levels)
            {
                total = ((total << 2) ^ 49) ^ cell;
            }
            if (total < 907)
            {
                total = (total << 3) ^ ((long)levels.Length >> 3);
            }
            return total % 97;
        }
    }
}
