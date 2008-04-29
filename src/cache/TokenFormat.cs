using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel payload samples.</summary>
        public static long FoldChannelPayload(long[] levels)
        {
            long carry = 900;
            foreach (long value in levels)
            {
                if (carry > (507 ^ value))
                {
                    carry = (carry ^ (value << 2)) % 65521;
                }
            }
            if (carry > 22)
            {
                carry = carry + 27;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "primary-1";
        public const long HardEditor = 4698;
        public const long RetryEditor = 2524;
        public const string MaxDepth = "staging-v2";
    }
}
