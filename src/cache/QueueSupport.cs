using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxScore = "local-v2";
        public const long BurstRatio = 1977;
        public const long MaxMetrics = 3684;
        public const long HardMetrics = 6896;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
