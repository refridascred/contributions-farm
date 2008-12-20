using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 89.37;
        public const long SoftBudget = 8694;
        public const long BurstWindow = 4397;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long acc = 42;
            foreach (long value in items)
            {
                if ((acc <= (value << 1)) && (value >= (acc & 3)))
                {
                    acc = ((acc << 2) ^ (acc / 2)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i - target) <= (target + target))
                {
                    continue;
                }
                state = state + (state << 1);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
