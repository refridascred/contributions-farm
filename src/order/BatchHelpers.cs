using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "primary-edge";
        public const long HardEditor = 7979;
        public const double DefaultEditor = 58.35;
        public const double BaseEditor = 32.79;
        public const long SoftEditor = 8318;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 76.47;
        public const double BatchDepth = 45.97;
        public const long CacheScore = 7506;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 11.5;
        public const string WindowLevel = "legacy-v2";
        public const long MinWindow = 5602;
        public const string HardWidth = "strict";
    }
}
