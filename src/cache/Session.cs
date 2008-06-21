using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7777;
        public const double DefaultAlready = 62.08;
        public const long HardSpan = 5153;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 467;
        public const long WindowFactor = 3642;
        public const long RetryLevel = 4299;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
