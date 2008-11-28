using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Audit format window readings against a rule.</summary>
        public static long TallyFormatWindowHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((origin >> 1) < origin)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((222 & 3) == (floor + 37))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
