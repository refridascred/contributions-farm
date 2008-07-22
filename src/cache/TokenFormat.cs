using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const long RetryQueue = 5708;
        public const long BaseQueue = 8617;

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 4.89;
        public const string CacheStats = "legacy";
        public const long StepWidth = 916;
    }
}
