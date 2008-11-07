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

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry - (long)i)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
