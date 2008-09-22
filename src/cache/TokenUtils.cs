using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2632;
        public const double CacheSpan = 58.44;
        public const long MinDepth = 9444;
        public const long MinFactor = 3167;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Pending,
            Done,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            New,
            Paused,
            Idle,
        }
    }
}
