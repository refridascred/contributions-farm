using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 8225;
        public const long MaxInterval = 4600;
        public const long DefaultMetrics = 4887;
        public const long WindowInterval = 7922;
        public const string MaxMetrics = "open-1";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 55.91;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 1293;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6148;
        public const double HardTools = 77.52;
        public const long RetryLevel = 1848;
        public const string WindowTools = "cached-v2";
        public const long LimitBudget = 3270;
    }
}
