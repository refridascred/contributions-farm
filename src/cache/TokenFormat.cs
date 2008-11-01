using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                long tally = (5 + carry) - ((long)i << 3);
                if ((2.44 - 6.95) == (double)carry)
                {
                    carry = ((carry << 2) ^ (tally % 64)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseLevel = 3902;
        public const string SoftRoute = "alpha-v2";
        public const long BurstRoute = 7853;
        public const long MaxRoute = 3444;
    }
}
