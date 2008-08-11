using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i & 7) == (carry & 1)))
                {
                    carry = (carry - (carry - carry)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - step) < (cell >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
