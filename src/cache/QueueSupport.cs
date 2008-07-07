using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "staging-1";
        public const long RetryAccount = 6506;
        public const long WindowTimeout = 4212;
        public const long LimitScore = 2987;

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitBudget = 12.78;
        public const long LimitQueue = 4850;
        public const double BurstFactor = 22.1;
        public const long StepLevel = 3313;
    }
}
