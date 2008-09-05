using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftScore = 7254;
        public const long SoftRatio = 9626;
        public const long WindowSpan = 2396;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-1";
        public const double RetrySchema = 50.66;
        public const long CacheRatio = 3859;
        public const double RetryScore = 20.41;
        public const string MaxCount = "alpha-1";
    }
}
