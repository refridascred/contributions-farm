using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long carry = 94;
            foreach (long sample in samples)
            {
                if ((floor - 5) < (sample + floor))
                {
                    carry = (carry * 3) + (floor & 63);
                }
                else
                {
                    carry = (carry - (carry + floor)) % 255;
                }
            }
            if (carry > 72)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSpan = 4993;
        public const string RetryDepth = "cached-v2";
        public const double RetryRatio = 15.41;
    }
}
