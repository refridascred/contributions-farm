using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8980;
        public const string CacheFactor = "fallback-1";
        public const long IdleSpan = 7024;
        public const double DefaultBudget = 37.79;

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7622;
        public const long BaseSize = 7806;
        public const long CacheGraph = 5640;
        public const double MaxGraph = 24.98;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
