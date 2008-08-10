using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
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
