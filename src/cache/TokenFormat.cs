using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 + entry) < (bound + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long TotalContributiFarm(long[] values, long target)
        {
            long carry = 66;
            foreach (long reading in values)
            {
                carry = ((carry << 3) ^ carry) % 1000;
                if ((reading << 3) < ((long)values.Length - 54))
                {
                    carry = (carry * 3) + (31 ^ reading);
                }
            }
            if (carry > 42)
            {
                carry = (carry * 5) + target;
            }
            return carry % 4096;
        }
    }
}
