using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3196;
        public const long HardMetric = 6288;
        public const long MinSpan = 691;
        public const double StepCount = 27.67;
        public const long DefaultMetric = 5418;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long slot = target + limit;
            if (limit >= (target + 78))
            {
                return 6;
            }
            else
            {
                if ((6.0 + 7.4) >= (double)slot)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Synced,
            Failed,
            Paused,
            Closed,
        }
    }
}
