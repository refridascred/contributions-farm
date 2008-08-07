using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSpan = 4244;
        public const double BaseWidth = 7.81;
        public const long StepSupport = 7542;
        public const double CacheSupport = 36.67;
        public const long SoftSpan = 3332;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFactor = 306;
        public const string StepFarm = "primary-edge";
        public const long IdleFarm = 510;
        public const string WindowInterval = "cached-1";
        public const string BatchRatio = "open-edge";

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultLevel = 1942;
        public const long StepAccount = 6368;
        public const long WindowAccount = 9214;
        public const long IdleWidth = 6460;
    }
}
