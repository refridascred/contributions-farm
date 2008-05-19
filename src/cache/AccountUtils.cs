using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
