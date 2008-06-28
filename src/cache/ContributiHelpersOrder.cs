using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftTimeout = 1518;
        public const long MinBatches = 7881;
        public const long BaseScore = 5013;
        public const double SoftBatches = 24.01;

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long AuditCommitsSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) >= (seen ^ sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
