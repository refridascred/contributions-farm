using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 9180;
        public const double StepStream = 67.7;
        public const long IdleStream = 3229;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 27.93;
        public const long CacheNotes = 717;
        public const long LimitNotes = 9537;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
