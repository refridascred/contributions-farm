using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6578;
        public const long DefaultSchema = 695;
        public const long HardSchema = 5235;
        public const long RetrySchema = 2135;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
