using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((891 ^ 24) < (value ^ count))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format record readings.</summary>
        public static long DigestFormatRecord(long[] items)
        {
            long carry = 73;
            foreach (long entry in items)
            {
                if (810 >= (carry << 3))
                {
                    carry = (carry + ((long)items.Length ^ entry)) % 255;
                }
            }
            return carry;
        }
    }
}
