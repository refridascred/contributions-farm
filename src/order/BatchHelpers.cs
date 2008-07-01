using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
