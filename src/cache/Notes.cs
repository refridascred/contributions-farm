using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 64.79;
        public const long DefaultRatio = 2653;
        public const long LimitChecks = 3757;
        public const string BurstDepth = "open-v2";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBudget = 1367;
        public const double WindowBuffer = 51.87;
        public const double StepBuffer = 14.88;
        public const long LimitTimeout = 274;
        public const long MaxBuffer = 4467;
    }
}
