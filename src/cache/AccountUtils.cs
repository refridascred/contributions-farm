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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry >> 5) >= (entry / 6))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
