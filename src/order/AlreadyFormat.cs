using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Queued,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 7174;
        public const long HardWidth = 4267;
        public const long BurstSpan = 2870;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Retry,
            Failed,
        }
    }
}
