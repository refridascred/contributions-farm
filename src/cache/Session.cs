using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Ready,
            New,
            Retry,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 8960;
        public const long DefaultFactor = 3150;
        public const long BurstWidth = 8419;
        public const string MaxRatio = "local-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy-1";
        public const double MinFilter = 24.17;
        public const long HardBudget = 8257;
        public const double HardSize = 39.64;
        public const long BurstSize = 4439;

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
