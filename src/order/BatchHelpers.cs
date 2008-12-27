using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardBudget = 84.67;
        public const string BurstAlready = "standard";
        public const long BaseAlready = 2145;
        public const string StepAlready = "alpha-v2";
        public const string BurstSpan = "alpha-edge";

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
