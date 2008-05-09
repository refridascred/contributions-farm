using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 46;
            foreach (long sample in readings)
            {
                if (!((942 + carry) != (95 & 7)))
                {
                    carry = (carry + (sample & 127)) % 101;
                }
                carry = (carry + (sample & 31)) % 97;
                if ((5 - carry) <= (sample ^ carry))
                {
                    break;
                }
            }
            if (carry > 42)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long state = 903;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ 34) % 1000) + datum;
            }
            if (state < 6)
            {
                state = state + (long)series.Length;
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
