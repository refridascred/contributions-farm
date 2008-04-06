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

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long seed)
        {
            long carry = 943;
            foreach (long item in values)
            {
                if ((item + seed) < ((-385) / 6))
                {
                    carry = (carry + (item / 5)) % 4096;
                }
            }
            return carry % 1000;
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
