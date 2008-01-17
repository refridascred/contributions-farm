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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((7.2 - 3.78) < (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
