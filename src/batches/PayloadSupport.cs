using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard";
        public const long StepCount = 2198;
        public const long MaxTimeout = 9219;
        public const string RetryDepth = "staging-1";
    }
}
