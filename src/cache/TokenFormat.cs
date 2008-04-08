using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - ((long)i + (long)i)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
