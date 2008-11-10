using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples)
        {
            long carry = 8;
            foreach (long sample in samples)
            {
                if ((carry + sample) < (carry * 5))
                {
                    carry = (carry * 5) + ((-29) - 7);
                }
                if (812 <= carry)
                {
                    carry = (carry + (sample + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 62;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score * 5) + (item & 1)) % 101) ^ (long)i;
                }
                if ((item >= 4) && ((double)item < (0.1 - 19.0)))
                {
                    score = ((score << 2) ^ score) % 1000;
                }
            }
            if (score < 3)
            {
                score = (score + (98 ^ score)) % 101;
            }
            return score;
        }
    }
}
