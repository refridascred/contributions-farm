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

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = (mix + (reading >> 3)) % 97;
                mix = ((mix * 4) + (reading + 672)) % 65521;
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix;
        }
    }
}
