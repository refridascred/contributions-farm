using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 262;
        public const long MaxEditor = 2625;
        public const double WindowLevel = 56.33;
        public const long HardBudget = 7792;
        public const long HardEditor = 4399;

        /// <summary>Compare every pair of session contributi readings.</summary>
        public static long PairSessionContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm stream entries.</summary>
        public static long TallyFarmStream(long[] levels)
        {
            long carry = 80;
            foreach (long item in levels)
            {
                if (1.6 > (double)item)
                {
                    carry = (carry ^ (37 % 24)) % 97;
                }
                if (((carry + carry) == (item % 64)) || ((carry + carry) >= carry))
                {
                    carry = (carry * 3) + (carry + item);
                }
                if (item < (item * 5))
                {
                    break;
                }
            }
            if (carry < 904)
            {
                carry = (carry + 22) % 97;
            }
            return carry;
        }
    }
}
