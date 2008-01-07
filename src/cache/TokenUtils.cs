using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8701;
        public const double BatchTools = 76.67;
        public const long LimitTools = 1935;
        public const double StepTools = 81.62;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 9474;
        public const long SoftInterval = 1053;
        public const string RetryCache = "standard-edge";
        public const double BurstInterval = 19.25;
    }
}
