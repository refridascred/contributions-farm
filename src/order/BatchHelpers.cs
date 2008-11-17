using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long BurstEntry = 2732;
        public const long LimitSpan = 4515;
        public const long BatchEntry = 7008;
        public const double RetryScore = 25.63;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSpan = 9157;
        public const long MaxGithubfarm = 2373;
        public const long BatchGithubfarm = 49;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-1";
        public const string BurstMetrics = "legacy-v2";
        public const string DefaultFactor = "strict-edge";
        public const string LimitFactor = "legacy-1";
    }
}
