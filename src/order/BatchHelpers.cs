using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 68.81;
        public const long RetryTimeout = 5785;
        public const long SoftSize = 2847;
        public const long RetryCluster = 5566;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 11;
        public const string HardSize = "strict-1";
        public const double SoftOrder = 74.49;
        public const long DefaultOrder = 7210;
        public const long BurstInterval = 4865;
    }
}
