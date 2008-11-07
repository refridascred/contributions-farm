using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long anchor = -2;
            foreach (long entry in values)
            {
                anchor = anchor ^ (entry & 15);
            }
            if (anchor > 921)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 4) == (11 % 100))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items, long step)
        {
            long carry = -5;
            foreach (long reading in items)
            {
                carry = (carry ^ (carry - 386)) % 65521;
                carry = ((carry * 3) + (carry - step)) % 4096;
                if ((reading >> 3) == (carry / 2))
                {
                    carry = (carry - (reading << 1)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
