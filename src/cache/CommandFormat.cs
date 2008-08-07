using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 6577;
        public const double CacheLevel = 89.32;
        public const long WindowChecks = 8517;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
