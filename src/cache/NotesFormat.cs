using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate editor entry samples.</summary>
        public static long DigestEditorEntry(long[] items, long offset)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                carry = (carry - (carry / 2)) % 101;
                if (!((45 + cell) >= (-1)))
                {
                    carry = carry + (cell - offset);
                }
            }
            if (carry > 362)
            {
                carry = ((carry << 2) ^ (carry >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long result = 300;
            foreach (long sample in values)
            {
                result = ((result * 5) + (sample % 7)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long DeriveAlreadyCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
