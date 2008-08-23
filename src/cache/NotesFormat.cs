using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next format notes value from a seed.</summary>
        public static long IterateFormatNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum - offset;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
