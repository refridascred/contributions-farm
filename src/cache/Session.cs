using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 74.74;
        public const long MaxSpan = 4735;
        public const double IdleCommand = 0.82;
        public const long BurstCommand = 6738;
        public const long HardWidth = 4706;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
