using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Retry,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 7967;
        public const long StepMetric = 6017;
        public const double BaseMetric = 11.84;
        public const string IdleLevel = "open";

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 26.56;
        public const long BatchCommand = 5464;
        public const string RetryScore = "alpha-1";
        public const long CacheTimeout = 798;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
