using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 3587;
        public const long WindowRatio = 7519;
        public const long BaseStats = 3977;
        public const long SoftStats = 2834;
        public const double DefaultInterval = 35.31;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
