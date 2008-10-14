using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state << 3) ^ state) % 4096) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
