using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 2563;
        public const long DefaultInterval = 6034;
        public const long MinStats = 9979;
        public const string RetryTimeout = "open-v2";
    }
}
