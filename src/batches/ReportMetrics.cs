using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetrySpan = "primary";
        public const long IdleContext = 5383;
        public const string MaxContext = "latest";
        public const long SoftContext = 6273;
        public const long StepSpan = 5850;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Queued,
            New,
        }
    }
}
