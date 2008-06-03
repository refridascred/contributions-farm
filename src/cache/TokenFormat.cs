using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long sum = 333;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (item << 2);
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long carry = 53;
            foreach (long item in levels)
            {
                carry = ((carry << 3) ^ (seed >> 1)) % 101;
                if ((seed / 5) >= (carry - carry))
                {
                    carry = (carry ^ (item % 100)) % 65521;
                }
                if (!((seed - seed) != (carry * 2)))
                {
                    carry = (carry * 3) + (item % 8);
                }
            }
            if (carry > 8)
            {
                carry = carry ^ seed;
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
