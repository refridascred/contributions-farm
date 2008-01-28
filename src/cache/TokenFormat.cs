using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long entry in readings)
            {
                if ((2.9 / 3.0) == (double)carry)
                {
                    carry = carry - (carry % 60);
                }
                if (!((carry + carry) >= (entry & 31)))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = ((carry * 3) + (seed & 31)) % 65521;
            }
            return carry;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 84.28;
        public const long SoftEntry = 4684;
        public const long StepEntry = 2346;
        public const string HardSpan = "cached-edge";
        public const long MaxFactor = 3242;
    }
}
