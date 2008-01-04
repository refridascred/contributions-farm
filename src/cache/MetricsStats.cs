using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count commits command pairs that satisfy a relation.</summary>
        public static long MatchCommitsCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-1";
        public const long CacheMetrics = 5921;
        public const long IdleCount = 6093;
        public const long BatchBudget = 4869;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i * 5) > ((long)i + 2)) || ((long)i >= (offset - offset)))
                {
                    mark = (mark - mark) % 255;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
