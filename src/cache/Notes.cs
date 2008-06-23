using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                if (!((6.0 * 1.7) < (double)carry))
                {
                    carry = (carry * 3) + 83;
                }
                if (!(carry >= (limit - reading)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long offset)
        {
            long total = 571;
            foreach (long item in items)
            {
                if ((total - 24) <= (offset ^ total))
                {
                    total = (total ^ (6 % 64)) + item;
                }
                else
                {
                    total = ((total << 2) ^ 3) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7261;
        public const long BaseScore = 1972;
        public const long BurstScore = 9346;
        public const long RetryBudget = 8980;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 9085;
        public const string LimitStats = "staging";
        public const long BatchFactor = 7474;
        public const long HardStats = 8579;
        public const long SoftStats = 7372;
    }
}
