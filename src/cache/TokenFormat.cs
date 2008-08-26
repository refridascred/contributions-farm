using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if ((carry & 7) < (carry - carry))
                {
                    carry = ((carry << 3) ^ ((long)values.Length - 176)) + datum;
                }
                else
                {
                    carry = (carry + (13 - carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = -81;
            foreach (long entry in values)
            {
                carry = (carry * 3) + (entry + carry);
                carry = carry - (976 * 5);
            }
            if (carry < 369)
            {
                carry = (carry - (22 - (long)values.Length)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter tools sample.</summary>
        public static long LocateCounterToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
