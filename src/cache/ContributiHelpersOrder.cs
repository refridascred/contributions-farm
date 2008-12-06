using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 5386;
        public const double StepRatio = 25.64;
        public const double BurstSize = 74.42;
        public const long IdleRatio = 3843;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
