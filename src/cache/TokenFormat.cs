using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every context layout entry stays within the limit.</summary>
        public static bool CheckContextLayoutRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowDepth = 1813;
        public const long MaxFactor = 1681;
        public const long SoftScore = 881;
        public const double StepSpan = 88.54;
        public const string HardRatio = "cached-v2";

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long carry = -733;
            foreach (long entry in items)
            {
                if (carry > (-9))
                {
                    carry = (carry - entry) % 65521;
                }
            }
            if (carry < 20)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }
    }
}
