using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4321;
        public const string MinContributi = "fallback-edge";
        public const long BatchWidth = 5820;
        public const long StepContributi = 8587;
        public const long RetryContributi = 9227;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Done,
            Ready,
        }
    }
}
