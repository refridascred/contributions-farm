using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 28.88;
        public const long BaseReport = 5887;
        public const long SoftScore = 1101;
        public const double BatchBudget = 90.91;
        public const string SoftReport = "cached-1";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Done,
            Pending,
            Ready,
        }
    }
}
