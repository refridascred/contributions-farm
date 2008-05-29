using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Closed,
            Synced,
            Paused,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5958;
        public const long StepScore = 7384;
        public const string SoftInterval = "cached-edge";
        public const double SoftDepth = 68.61;
        public const long StepAccount = 1607;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
