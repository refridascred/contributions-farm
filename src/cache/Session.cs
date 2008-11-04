using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            New,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 58.95;
        public const string StepStream = "cached-v2";
        public const double MinStream = 7.86;
        public const double WindowStream = 81.43;
    }
}
