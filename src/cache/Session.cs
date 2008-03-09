using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }
    }
}
