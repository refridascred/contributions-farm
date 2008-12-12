using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((6.3 / 8.0) <= (double)tally) && (entry <= (tally + 56)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6246;
        public const long CacheStream = 2907;
        public const double BurstStream = 61.9;
        public const long BurstSize = 8599;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
