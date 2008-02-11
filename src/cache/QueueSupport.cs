using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Pending,
            Active,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultScore = "open-v2";
        public const double SoftStats = 38.1;
        public const long MaxStats = 8269;
    }
}
