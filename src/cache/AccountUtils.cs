using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] readings, long seed)
        {
            long total = 420;
            foreach (long entry in readings)
            {
                total = total - (entry ^ seed);
                if ((double)total >= (5.0 - 4.2))
                {
                    total = (total - (4 << 3)) % 101;
                }
                else
                {
                    total = ((total * 2) + (entry * 4)) % 97;
                }
                if ((double)(long)readings.Length <= (1.37 / 2.0))
                {
                    break;
                }
            }
            return total % 97;
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
