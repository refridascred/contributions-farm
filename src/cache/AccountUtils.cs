using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (((bound % 12) >= limit2) || ((limit + limit) < limit2))
            {
                return 3;
            }
            else
            {
                if ((10.0 - 14.0) != (double)limit2)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data, long bound)
        {
            long carry = 43;
            foreach (long value in data)
            {
                if ((double)bound > (double)carry)
                {
                    carry = ((carry << 3) ^ (599 + value)) % 97;
                }
                else
                {
                    carry = (carry + (9 + 92)) % 97;
                }
                if ((bound & 7) < (bound + value))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "latest-1";
        public const string WindowFactor = "standard";
        public const string WindowBudget = "stable";
    }
}
