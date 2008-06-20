using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 1579;
        public const long RetryLevel = 7261;
        public const string IdleTimeout = "local-1";
        public const double RetryScore = 7.46;
        public const long BatchCommits = 1472;

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "alpha-v2";
        public const string BatchCount = "strict";
        public const long SoftCount = 4240;
        public const string StepWidth = "stable-edge";
    }
}
