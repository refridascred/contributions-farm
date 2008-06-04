using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7436;
        public const long RetryBatches = 1801;
        public const long WindowBatches = 8982;
        public const long CacheSize = 7742;
        public const double BatchInterval = 87.5;

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)origin != (19.0 - 17.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
