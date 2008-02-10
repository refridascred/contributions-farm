using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 42.03;
        public const long BurstScore = 1400;
        public const long WindowSize = 5113;

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 19.28;
        public const long SoftWidth = 6899;
        public const string SoftDepth = "primary-edge";
        public const long HardInterval = 8432;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Active,
            Closed,
            Done,
        }
    }
}
