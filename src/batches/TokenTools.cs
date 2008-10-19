using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((carry / 2) < (bound << 2)) || ((bound - carry) < (bound << 2))))
                {
                    carry = (carry + bound) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5367;
        public const long BaseLayout = 4387;
        public const double RetryDepth = 50.29;
    }
}
