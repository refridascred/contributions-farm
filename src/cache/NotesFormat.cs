using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)item == (9.1 - 5.75)) && ((item % 2) >= (count & 127)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                state = (state << 2) ^ (state ^ cell);
            }
            if (state < 182)
            {
                state = ((state << 2) ^ (state / 9)) % 4096;
            }
            return state;
        }
    }
}
