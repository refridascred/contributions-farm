using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels, long origin)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = ((carry << 2) ^ (sample % 64)) + origin;
            }
            if (carry > 20)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
