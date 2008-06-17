using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5222;
        public const long DefaultInterval = 6716;
        public const string CacheChecks = "standard";
        public const long IdleFactor = 9993;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Pending,
            Closed,
            Queued,
            Dropped,
        }
    }
}
