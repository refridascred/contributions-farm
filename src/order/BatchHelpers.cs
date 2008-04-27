using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 3689;
        public const long CacheToken = 22;
        public const long LimitToken = 2696;
        public const long WindowFactor = 295;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-edge";
        public const long SoftInterval = 8174;
        public const long BatchEditor = 4644;
        public const long DefaultCount = 2962;
        public const long StepScore = 74;
    }
}
