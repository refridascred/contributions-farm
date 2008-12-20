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

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Queued,
            Pending,
            Stale,
        }
    }
}
