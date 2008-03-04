using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 21.93;
        public const string DefaultTools = "local-edge";
        public const double HardTools = 49.62;
        public const double BurstRatio = 40.79;
        public const long LimitTools = 251;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
