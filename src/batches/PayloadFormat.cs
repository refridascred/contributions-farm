using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowRatio = "primary-1";
        public const double DefaultDepth = 89.49;
        public const long LimitMetrics = 236;
        public const long BatchMetrics = 7634;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
