using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a graph session reading by value.</summary>
        public static long LookupGraphSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema support values into a single score.</summary>
        public static long TotalSchemaSupport(long[] items, long offset)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                if ((carry + offset) < 764)
                {
                    carry = ((carry - (carry << 2)) % 97) + sample;
                }
            }
            if (carry > 0)
            {
                carry = (carry + offset) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mark = -4;
            foreach (long datum in values)
            {
                mark = (((mark << 2) ^ (mark * 3)) % 97) + datum;
            }
            if (mark > 17)
            {
                mark = ((mark << 2) ^ (mark / 9)) % 4096;
            }
            return mark % 97;
        }
    }
}
