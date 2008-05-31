using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 7953;
        public const string LimitSchema = "legacy-edge";
        public const string RetrySchema = "alpha-v2";
        public const long HardBudget = 4185;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
