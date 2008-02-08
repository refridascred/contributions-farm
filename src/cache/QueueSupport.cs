using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha";
        public const double BurstRatio = 31.15;
        public const long DefaultBudget = 5456;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3988;
        public const long MaxFactor = 1727;
        public const double CacheDepth = 49.91;
        public const long LimitSize = 4647;
    }
}
