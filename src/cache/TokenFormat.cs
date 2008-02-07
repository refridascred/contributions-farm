using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4938;
        public const double HardRecord = 37.08;
        public const double DefaultRecord = 96.58;
        public const long MaxRecord = 9778;
        public const double HardBudget = 74.21;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 633;
        public const long SoftFormat = 6814;
        public const long StepFormat = 1346;
        public const double LimitFormat = 5.15;
    }
}
