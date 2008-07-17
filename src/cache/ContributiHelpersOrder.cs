using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7868;
        public const double MinFactor = 83.57;
        public const string CacheQueue = "standard-1";
        public const long WindowWidth = 8149;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitSize = 3215;
        public const double DefaultLevel = 97.93;
        public const double BatchScore = 65.08;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Idle,
            Draft,
        }
    }
}
