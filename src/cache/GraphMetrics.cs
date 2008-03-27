using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleScore = "legacy-edge";
        public const double DefaultLayout = 37.1;
        public const long RetrySize = 5693;
        public const long BaseCount = 7779;
        public const long MinLayout = 5603;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
