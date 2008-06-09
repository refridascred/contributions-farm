using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up stats route samples.</summary>
        public static long CompareStatsRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long carry = 6;
            foreach (long value in items)
            {
                carry = (carry + value) % 101;
                if ((carry + value) <= (72 + value))
                {
                    carry = (carry << 2) ^ (value >> 5);
                }
                else
                {
                    carry = (carry - (carry - carry)) % 101;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry - carry)) % 65521;
            }
            return carry % 97;
        }
    }
}
