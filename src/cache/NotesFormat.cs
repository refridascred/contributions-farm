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

        /// <summary>Measure how many profile queue samples are out of range.</summary>
        public static long CountProfileQueueMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((4.2 - 3.3) != (double)datum) && ((8 + count) < (count + 14))) || ((16.0 * 18.0) > (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
