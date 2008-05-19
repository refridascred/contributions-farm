using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 89.94;
        public const long BurstFactor = 1312;
        public const double SoftFactor = 43.49;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((17 >= (value >> 3)) && ((count - count) == (value + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long carry = 71;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry & 63)) % 1000;
                if (cell <= (carry + carry))
                {
                    carry = carry - (carry + cell);
                }
                else
                {
                    carry = (carry + cell) % 101;
                }
            }
            return carry;
        }
    }
}
