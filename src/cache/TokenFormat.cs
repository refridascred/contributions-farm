using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support filter value from a seed.</summary>
        public static long RollSupportFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long DigestEditorFormat(long[] samples)
        {
            long carry = 997;
            foreach (long reading in samples)
            {
                if (((reading ^ reading) >= carry) || (((long)samples.Length >> 4) != (carry + carry)))
                {
                    carry = carry ^ ((-44) ^ reading);
                }
            }
            if (carry < (-51))
            {
                carry = ((carry << 3) ^ (carry + 8)) % 1000;
            }
            return carry % 4096;
        }
    }
}
