using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 2852;
        public const string SoftInterval = "legacy-edge";
        public const long HardBatch = 1838;
    }
}
