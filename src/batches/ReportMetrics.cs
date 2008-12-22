using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
