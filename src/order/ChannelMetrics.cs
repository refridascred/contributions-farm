using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entry entries.</summary>
        public static long DigestSessionEntry(long[] levels)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1319;
        public const long RetryFilter = 5167;
        public const long StepFilter = 9739;
    }
}
