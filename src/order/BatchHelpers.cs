using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7653;
        public const string BaseContext = "legacy";
        public const long MaxLevel = 9602;
        public const long RetryContext = 1927;
        public const long StepContext = 8722;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 7.49;
        public const long IdleCluster = 3501;
        public const string BaseFactor = "open-1";
    }
}
