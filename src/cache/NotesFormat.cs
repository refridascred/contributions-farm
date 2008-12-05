using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 5905;
        public const long LimitCache = 808;
        public const long CacheLevel = 9625;

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 87.73;
        public const long SoftFactor = 4527;
        public const double MaxLevel = 0.82;
        public const long BaseCount = 1769;
        public const long BurstCache = 8366;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Failed,
            Stale,
        }
    }
}
