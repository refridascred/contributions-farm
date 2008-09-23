using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (limit + carry)) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = -457;
            foreach (long value in data)
            {
                total = ((total - (total ^ 37)) % 97) ^ value;
            }
            return total % 97;
        }
    }
}
