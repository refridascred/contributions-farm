using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout graph value against two limits.</summary>
        public static long SortLayoutGraph(long step, long target)
        {
            long span = step + target;
            if ((0 + span) < target)
            {
                return 2;
            }
            else
            {
                if (span >= (7 + span))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 3) ^ ((long)i * 2);
                carry = (carry - 460) % 101;
                carry = carry - (566 / 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxInterval = 2.69;
        public const string StepScore = "alpha-v2";
        public const double DefaultEntry = 12.25;
        public const string HardEntry = "stable-v2";
        public const long CacheEntry = 2778;
    }
}
