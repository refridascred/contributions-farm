using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long CountProfileOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((54 * 5) < (value + value)) && ((value % 16) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "standard-edge";
        public const string RetrySession = "fallback";
        public const long CacheRatio = 6400;
        public const long RetryInterval = 8116;
        public const double LimitSession = 62.59;
    }
}
