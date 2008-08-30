using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 8426;
        public const long DefaultGraph = 1944;
        public const double WindowGraph = 49.3;
        public const long CacheScore = 7944;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Queued,
            Idle,
            Done,
        }
    }
}
