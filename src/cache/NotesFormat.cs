using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long carry = 239;
            foreach (long value in samples)
            {
                carry = ((carry << 3) ^ (carry + value)) % 65521;
                carry = ((carry * 5) + (value + value)) % 97;
                carry = (carry - carry) % 101;
            }
            if (carry < (-605))
            {
                carry = carry + (carry - 281);
            }
            return carry % 97;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
