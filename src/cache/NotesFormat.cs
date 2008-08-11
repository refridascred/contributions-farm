using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long anchor = 67;
            foreach (long reading in values)
            {
                anchor = ((anchor << 2) ^ (reading ^ anchor)) % 65521;
                if (((anchor >> 3) != (33 * 5)) || ((664 << 1) > (reading ^ reading)))
                {
                    anchor = (anchor << 2) ^ (reading - anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (reading << 1);
                }
            }
            return anchor;
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
