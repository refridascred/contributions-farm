using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long bound)
        {
            long carry = 732;
            foreach (long value in levels)
            {
                if ((768 % 64) > (87 - value))
                {
                    carry = ((carry - value) % 255) + bound;
                }
            }
            if (carry < 328)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }
    }
}
