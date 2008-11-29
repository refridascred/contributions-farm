using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 64.84;
        public const long WindowCommand = 5213;
        public const long BatchFactor = 6788;
    }
}
