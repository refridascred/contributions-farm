using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxBudget = "standard";
        public const long HardSize = 7694;
        public const long WindowWidth = 5481;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 76.47;
        public const double BatchDepth = 45.97;
        public const long CacheScore = 7506;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
