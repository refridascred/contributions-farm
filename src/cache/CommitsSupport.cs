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

        /// <summary>Digest a series of profile order entries.</summary>
        public static long CombineProfileOrder(long[] items, long seed)
        {
            long sum = -787;
            foreach (long item in items)
            {
                if ((5.0 + 18.0) >= (double)sum)
                {
                    sum = ((sum * 3) + (item >> 3)) - seed;
                }
                if (sum >= (item - 39))
                {
                    break;
                }
            }
            return sum;
        }

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
