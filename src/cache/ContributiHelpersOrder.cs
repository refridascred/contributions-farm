using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3500;
        public const long BatchFactor = 9790;
        public const double RetrySupport = 42.13;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 5336;
        public const string StepWindow = "strict-v2";
        public const double DefaultSize = 96.13;
        public const double BurstWidth = 90.33;
        public const long MinWindow = 3744;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4826;
        public const long CacheLevel = 2955;
        public const long IdleLevel = 8242;
        public const string WindowBudget = "standard-1";
    }
}
