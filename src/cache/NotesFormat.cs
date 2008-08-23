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

        /// <summary>Fold a list of session schema readings.</summary>
        public static long ScoreSessionSchema(long[] samples)
        {
            long result = 67;
            foreach (long datum in samples)
            {
                result = (result + datum) % 97;
            }
            if (result < 619)
            {
                result = (result ^ 0) % 4096;
            }
            return result % 97;
        }
    }
}
