using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long mark = 37;
            foreach (long entry in values)
            {
                if ((double)entry > 5.0)
                {
                    mark = (mark - (entry & 7)) + seed;
                }
                else
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 64)
            {
                mark = (mark ^ (mark % 8)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values, long seed)
        {
            long carry = 88;
            foreach (long cell in values)
            {
                if ((seed + 81) >= (carry & 31))
                {
                    carry = (((carry * 5) + carry) % 4096) - cell;
                }
            }
            return carry;
        }
    }
}
