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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 44.6;
        public const double BurstBudget = 12.43;
        public const long WindowFactor = 1415;
        public const long IdleTimeout = 465;
    }
}
