using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "staging-1";
        public const long HardFactor = 6497;
        public const long StepSupport = 1881;
        public const long MinSpan = 850;
    }
}
