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

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "local-1";
        public const long RetryWidth = 5030;
        public const long StepSupport = 2781;
    }
}
