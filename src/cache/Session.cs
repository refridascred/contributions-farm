using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "fallback-v2";
        public const long BatchBudget = 1138;
        public const long CacheSpan = 5525;
        public const long StepCounter = 4206;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
