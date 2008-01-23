using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSize = 2731;
        public const long SoftAlready = 8276;
        public const long BatchAlready = 1946;
        public const string StepAlready = "alpha-1";
    }
}
