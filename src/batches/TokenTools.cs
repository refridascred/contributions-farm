using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long carry = 25;
            foreach (long entry in items)
            {
                carry = ((carry + (entry / 7)) % 97) - offset;
                carry = (carry + (entry >> 2)) % 255;
                carry = ((carry * 2) + (entry - entry)) % 4096;
            }
            if (carry > 8)
            {
                carry = (carry * 4) + ((long)items.Length + (-53));
            }
            return carry;
        }
    }
}
