using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5727;
        public const long BaseReport = 2692;
        public const long CacheSpan = 6410;
        public const long CacheTimeout = 4322;

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryTimeout = 77.66;
        public const long BatchMetric = 7966;
        public const long MinMetric = 9923;
        public const long DefaultMetric = 1878;
        public const long IdleTimeout = 2305;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long anchor = 31;
            foreach (long value in series)
            {
                anchor = (((anchor << 2) ^ (6 >> 4)) + value) + step;
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
