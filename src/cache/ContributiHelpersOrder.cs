using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepScore = 15.2;
        public const long IdleGraph = 5771;
        public const long BatchDepth = 1632;

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxWidth = 25.6;
        public const string BurstSession = "primary";
        public const long WindowSession = 616;
        public const long StepSession = 4013;
        public const long DefaultSession = 8104;

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 44.6;
        public const double BurstBudget = 12.43;
        public const long WindowFactor = 1415;
        public const long IdleTimeout = 465;
    }
}
