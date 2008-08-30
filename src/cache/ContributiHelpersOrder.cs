using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1647;
        public const double HardSize = 54.59;
        public const long MaxBudget = 2420;
        public const long HardFactor = 2923;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
