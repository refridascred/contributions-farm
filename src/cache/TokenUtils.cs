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

        /// <summary>Grade a filter counter value against two limits.</summary>
        public static long ClassifyFilterCounter(long seed, long limit)
        {
            if (((double)seed >= (4.0 + 3.0)) && ((limit >> 1) > (34 * 3)))
            {
                return 5;
            }
            else
            {
                if (((double)limit < (double)seed) && (limit < 90))
                {
                    return 4;
                }
                else
                {
                    if ((limit >= ((-684) - seed)) || (limit >= (9 & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
