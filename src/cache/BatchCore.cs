using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "fallback-edge";
        public const long SoftBudget = 6963;
        public const string MaxGraph = "standard";

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "staging";
        public const long HardWindow = 9358;
        public const long CacheWindow = 2244;
        public const double RetryWindow = 14.54;
    }
}
