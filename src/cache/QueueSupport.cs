using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 3895;
        public const string BatchSpan = "fallback-edge";
        public const string HardLevel = "standard-v2";
    }
}
