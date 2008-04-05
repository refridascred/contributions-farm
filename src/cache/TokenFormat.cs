using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 72;
            foreach (long value in values)
            {
                if (!((double)value > (1.54 / 2.0)))
                {
                    carry = ((carry * 3) + value) % 101;
                }
                carry = (carry - (value + value)) % 65521;
                if ((value * 3) <= (61 + 2))
                {
                    break;
                }
            }
            if (carry < 561)
            {
                carry = (carry ^ (carry - carry)) % 4096;
            }
            return carry;
        }
    }
}
