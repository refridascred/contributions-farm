using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 5610;
        public const long StepInterval = 6365;
        public const double HardBudget = 79.46;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 27.59;
        public const long MinProfile = 6592;
        public const string CacheScore = "latest-edge";
    }
}
