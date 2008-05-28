using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 5588;
        public const long HardContributi = 9164;
        public const long CacheCount = 1750;
        public const string BurstInterval = "standard-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitBudget = "standard-v2";
        public const double RetryLevel = 62.58;
        public const long BatchDepth = 8445;
        public const long IdleWidth = 4302;
        public const long StepWidth = 3251;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
