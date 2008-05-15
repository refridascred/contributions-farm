using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            New,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7488;
        public const double BatchTimeout = 94.28;
        public const long MinSpan = 1401;
        public const long DefaultRatio = 4086;

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long origin)
        {
            long result = 26;
            foreach (long sample in readings)
            {
                if (!(origin > (572 ^ 7)))
                {
                    result = (result + (2 - sample)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Score { get; set; }
            public double Token { get; set; }
        }
    }
}
