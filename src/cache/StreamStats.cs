using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 86.07;
        public const long HardCount = 3731;
        public const long BaseReport = 9591;
        public const long HardBudget = 3567;
        public const long LimitSpan = 1798;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Draft,
            Failed,
        }
    }
}
