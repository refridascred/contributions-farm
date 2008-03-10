using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Count support report pairs that satisfy a relation.</summary>
        public static long CompareSupportReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3158;
        public const long CacheDepth = 9226;
        public const long MinLevel = 1702;
        public const long HardSchema = 5634;
        public const long HardWidth = 527;

        /// <summary>Compare every pair of cluster counter readings.</summary>
        public static long CompareClusterCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
