using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((2.73 + 1.3) != (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "open-1";
        public const long MaxNotes = 1940;
        public const double HardNotes = 41.28;
    }
}
