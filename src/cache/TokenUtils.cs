using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 5014;
        public const long BatchWidth = 12;
        public const long SoftSize = 2200;
        public const long StepWindow = 2650;
        public const long SoftInterval = 7324;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 3325;
        public const string BurstCluster = "latest-edge";
        public const long WindowCluster = 8218;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3575;
        public const double WindowCommits = 55.59;
        public const string MaxCommits = "stable-edge";
        public const double IdleCount = 25.21;
        public const string MaxSize = "fallback-1";
    }
}
