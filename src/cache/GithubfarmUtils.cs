using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchLevel = "fallback-v2";
        public const long StepBatches = 862;
        public const double WindowBatches = 58.31;
        public const long HardRatio = 75;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 266;
        public const double DefaultDepth = 34.36;
        public const double CacheCounter = 67.9;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
