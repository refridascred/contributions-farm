using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 629;
        public const long MaxScore = 1533;
        public const double LimitAlready = 95.86;
        public const double BurstAlready = 93.38;
        public const long BatchSpan = 7670;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7791;
        public const string StepRatio = "latest-v2";
        public const double IdleSupport = 0.74;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 1.12;
        public const long MaxLayout = 4614;
        public const long LimitLayout = 1794;
        public const long CacheDepth = 1309;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstWidth = "cached-v2";
        public const long WindowWidth = 8883;
        public const long BatchSize = 2950;
    }
}
