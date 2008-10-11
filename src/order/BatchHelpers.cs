using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "local-edge";
        public const double MaxAccount = 27.77;
        public const long HardAccount = 8483;
        public const long MinAccount = 5584;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Idle,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5714;
        public const double LimitTimeout = 58.19;
        public const string StepScore = "legacy";
        public const string SoftPayload = "primary-v2";
        public const long BatchPayload = 3061;
    }
}
