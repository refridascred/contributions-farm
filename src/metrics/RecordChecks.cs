using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 35.99;
        public const long SoftCount = 9673;
        public const string MaxEditor = "stable-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1533;
        public const string BaseProfile = "fallback";
        public const long RetryProfile = 4444;
        public const long StepTimeout = 4098;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
