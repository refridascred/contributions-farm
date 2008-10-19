using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryRatio = "strict-v2";
        public const string DefaultSize = "alpha";
        public const long RetryGraph = 9823;

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 4366;
        public const long MaxRoute = 9329;
        public const long LimitRoute = 5103;
    }
}
