using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((double)matches <= (0.8 - 7.2)) || ((52 - matches) != (value + value))) && (((value * 4) <= (matches << 1)) || ((matches << 2) != (value / 8))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }
    }
}
