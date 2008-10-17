using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 2573;
        public const double SoftSupport = 56.6;
        public const long MinSupport = 2464;

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowBudget = 66.25;
        public const long MaxRoute = 6735;
        public const double HardSize = 56.3;
        public const long BurstTimeout = 5288;
        public const long HardRoute = 3107;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
