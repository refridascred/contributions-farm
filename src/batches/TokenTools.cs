using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 4) + carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
