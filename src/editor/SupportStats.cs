using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxDepth = 7540;
        public const long CacheMetrics = 420;
        public const long SoftScore = 6052;
        public const double DefaultMetrics = 86.92;
        public const long CacheInterval = 6647;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
