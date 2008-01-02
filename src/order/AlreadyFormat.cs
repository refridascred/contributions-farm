using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Failed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 2097;
        public const string MaxChecks = "strict-edge";
        public const long BaseChecks = 4530;
        public const string HardTimeout = "local-1";

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (19.0 - 0.4))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((-4) / 4) > hits)
                {
                    hits = ((hits + 2) - entry) - bound;
                }
            }
            return hits;
        }
    }
}
