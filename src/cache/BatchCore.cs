using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowLevel = "fallback-v2";
        public const long LimitDepth = 5713;
        public const long BatchBudget = 4994;
        public const string BatchCache = "fallback-v2";
        public const string RetryCache = "open-v2";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 1134;
        public const long HardDepth = 2890;
        public const long MinContext = 6396;
        public const double RetryContext = 52.57;
        public const double WindowBudget = 83.51;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
