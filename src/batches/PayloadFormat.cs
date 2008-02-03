using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinBudget = 31.91;
        public const long BurstSize = 5593;
        public const double MaxTimeout = 31.67;
        public const long HardRoute = 2105;
        public const long IdleRatio = 908;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Queued,
            Paused,
            Draft,
        }
    }
}
