using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long floor)
        {
            long carry = 445;
            foreach (long reading in levels)
            {
                if ((carry >> 5) < (reading + floor))
                {
                    carry = (carry ^ (carry ^ 74)) % 4096;
                }
            }
            if (carry < 527)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
