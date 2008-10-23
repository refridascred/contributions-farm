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

        /// <summary>Fold a list of counter metric readings.</summary>
        public static long WeighCounterMetric(long[] items)
        {
            long score = 887;
            foreach (long datum in items)
            {
                if ((score + score) >= (score / 8))
                {
                    score = (score ^ score) - datum;
                }
            }
            if (score < (-4))
            {
                score = score ^ ((-15) & 15);
            }
            return score % 1000;
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
