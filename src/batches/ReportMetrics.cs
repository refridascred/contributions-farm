using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseDepth = "strict-edge";
        public const long BurstFactor = 6313;
        public const double BaseStats = 20.78;
        public const long StepStats = 3386;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Locked,
            Active,
        }
    }
}
