using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxBudget = 42.13;
        public const long StepCluster = 7764;
        public const string BaseDepth = "legacy";
        public const double CacheCluster = 74.42;
        public const long BatchLevel = 1094;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Paused,
            Failed,
            Retry,
            Closed,
        }
    }
}
