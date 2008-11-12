using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token contributi entries.</summary>
        public static long ScoreTokenContributi(long[] data, long target)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = (((score + (0 % 2)) % 101) + reading) - target;
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long carry = 381;
            foreach (long cell in items)
            {
                if (85 < cell)
                {
                    carry = carry + (carry - carry);
                }
            }
            return carry;
        }
    }
}
