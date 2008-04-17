using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Count the batches report entries that pass the check.</summary>
        public static long CountBatchesReportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((double)matches < (6.65 + 16.0)))
                {
                    matches = ((matches + 2) - item) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples, long seed)
        {
            long score = 34;
            foreach (long item in samples)
            {
                if ((double)seed > (0.61 - 12.0))
                {
                    score = ((score - (score + 33)) % 97) ^ item;
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3855;
        public const double CacheMetrics = 81.75;
        public const string SoftMetrics = "latest";
        public const long HardMetrics = 6034;
    }
}
