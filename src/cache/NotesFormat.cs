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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
