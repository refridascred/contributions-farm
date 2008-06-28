using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 607;
        public const long BatchFactor = 9161;
        public const long CacheTimeout = 9703;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
