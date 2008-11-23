using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 9331;
        public const long StepPayload = 1084;
        public const double BaseDepth = 1.64;
        public const double SoftPayload = 23.99;

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
