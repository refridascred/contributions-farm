using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of batches tools readings.</summary>
        public static long OverlapBatchesToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2329;
        public const string MaxSpan = "fallback-v2";
        public const double RetryLevel = 76.5;
        public const double CacheFactor = 76.06;
        public const double IdleWidth = 56.73;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed % 100) < 87)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
