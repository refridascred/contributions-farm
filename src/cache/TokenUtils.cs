using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSpan = 5946;
        public const long DefaultWidth = 6142;
        public const double BurstSupport = 97.54;
        public const long StepSupport = 4616;

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
