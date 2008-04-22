using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 40.83;
        public const double LimitWidth = 54.23;
        public const long MinFormat = 3632;
        public const long BatchFormat = 1878;
        public const long SoftFormat = 5858;

        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool CheckLayoutFormatBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Iterate the cluster notes series from a seed.</summary>
        public static long IterateClusterNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((2 + 59) >= origin)
                {
                    mark = mark - origin;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
