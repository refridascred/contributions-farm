using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (offset < (2 << 3))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 6499;
        public const long LimitWindow = 407;
        public const string BurstWindow = "alpha-1";
    }
}
