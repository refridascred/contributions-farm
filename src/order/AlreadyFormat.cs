using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)step == (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 9488;
        public const long RetryBatches = 9407;
        public const string LimitFactor = "local-1";
        public const long StepScore = 1177;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Draft,
            Locked,
            Idle,
        }
    }
}
