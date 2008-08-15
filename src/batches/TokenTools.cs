using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheScore = "latest-1";
        public const long BaseFarm = 1228;
        public const long CacheBudget = 3822;
        public const long StepFarm = 9429;
    }
}
