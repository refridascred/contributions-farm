using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                long offset = (carry & 1) % 24;
                carry = (carry << 3) ^ offset;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = 50;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample - carry))
                {
                    carry = ((carry * 4) + (carry + sample)) % 101;
                }
            }
            if (carry < 51)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
