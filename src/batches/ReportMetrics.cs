using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7933;
        public const long SoftSupport = 4306;
        public const long LimitWidth = 6313;
        public const double MaxSupport = 36.73;
    }
}
