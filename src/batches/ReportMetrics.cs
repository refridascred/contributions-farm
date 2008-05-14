using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Dropped,
            Idle,
            Active,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 9956;
        public const string BaseScore = "cached-edge";
        public const long IdleTimeout = 668;

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultFactor = "open-1";
        public const long MinFactor = 7242;
        public const long IdleDepth = 1674;
        public const long StepDepth = 1500;
        public const long BurstGraph = 3346;
    }
}
