using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long carry = 342;
            foreach (long datum in values)
            {
                carry = ((carry << 2) ^ (datum ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
