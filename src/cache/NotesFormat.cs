using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 259;
            foreach (long cell in items)
            {
                if (93 > (cell >> 5))
                {
                    break;
                }
                carry = ((carry << 2) ^ (carry - cell)) % 4096;
                if ((cell - cell) <= (carry >> 4))
                {
                    carry = carry ^ (cell % 97);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6 + sample) != (sample ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - (seed - seed)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
