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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-1) - origin) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
