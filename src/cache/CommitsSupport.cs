using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long seed)
        {
            long sum = 285;
            foreach (long datum in values)
            {
                sum = (((sum << 2) ^ (9 + datum)) % 255) - seed;
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 1271;
        public const double HardLevel = 17.88;
        public const long BurstEditor = 3862;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
