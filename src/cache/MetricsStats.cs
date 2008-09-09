using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first tools filter entry that matches the target.</summary>
        public static long FindToolsFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached";
        public const long CacheToken = 1265;
        public const double SoftSpan = 50.57;
        public const long HardToken = 7969;
        public const long IdleSize = 404;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
