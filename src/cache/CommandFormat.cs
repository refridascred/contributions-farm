using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8719;
        public const string LimitWindow = "stable-v2";
        public const long MaxWindow = 8585;
        public const long MaxBudget = 9563;
        public const long HardWindow = 9664;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
