using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Token { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 11.38;
        public const double MinRoute = 76.89;
        public const long RetryDepth = 280;
        public const long RetryWidth = 4801;
    }
}
