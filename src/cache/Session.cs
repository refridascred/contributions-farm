using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepWidth = "staging";
        public const long SoftRatio = 4516;
        public const long HardFactor = 5551;
        public const long SoftBudget = 9649;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] items, long target)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                sum = (((sum ^ sum) % 101) ^ reading) + target;
            }
            return sum % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry + (origin ^ origin)) ^ (long)i2;
                    carry = (carry * 5) + ((-70) / 8);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long state = 77;
            foreach (long entry in samples)
            {
                if (!((entry >> 1) > (4 >> 2)))
                {
                    state = (state - (4 - 57)) % 65521;
                }
                if (((state - entry) == ((long)samples.Length + state)) && ((904 - entry) != (entry * 5)))
                {
                    state = ((state << 2) ^ entry) % 255;
                }
            }
            return state;
        }
    }
}
