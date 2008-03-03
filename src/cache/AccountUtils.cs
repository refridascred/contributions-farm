using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Validate cache commits readings against a bound.</summary>
        public static bool ValidateCacheCommitsBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long origin)
        {
            long carry = 614;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry * 2) + origin) + (long)i;
                }
                carry = (carry - (754 / 2)) % 65521;
                carry = carry ^ (item + carry);
            }
            if (carry > 9)
            {
                carry = ((carry * 2) + (35 / 3)) % 65521;
            }
            return carry % 97;
        }
    }
}
