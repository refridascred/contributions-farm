using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9232;
        public const double MaxChecks = 44.75;
        public const long DefaultTimeout = 7988;
        public const long SoftSize = 9767;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
