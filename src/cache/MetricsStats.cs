using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Score { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Locate a notes report reading by value.</summary>
        public static long LookupNotesReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches ^ item) <= (matches + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Closed,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3760;
        public const long DefaultScore = 3660;
        public const long BatchInterval = 2089;
        public const double RetryDepth = 98.04;
    }
}
