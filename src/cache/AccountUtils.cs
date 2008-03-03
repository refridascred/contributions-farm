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

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 77.65;
        public const long LimitInterval = 9181;
        public const double BaseFormat = 47.17;
        public const string MinFormat = "cached-1";

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
