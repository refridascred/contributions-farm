using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4665;
        public const long SoftCount = 5636;
        public const long WindowCommand = 7679;
        public const long MinCommand = 2096;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 80.89;
        public const double WindowBatches = 69.68;
        public const long MinTimeout = 7476;
        public const long StepBatches = 2024;
        public const string WindowSpan = "alpha-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 4298;
        public const long IdleSize = 197;
        public const long BurstLevel = 3460;
        public const long BurstWindow = 7309;
        public const long HardWindow = 2533;
    }
}
