using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 9381;
        public const double CacheCounter = 23.86;
        public const long BaseInterval = 6638;
        public const long MinSize = 6356;

        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long SortRouteContributi(long target, long floor)
        {
            long bound = target - floor;
            if ((bound & 1) > bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound == (7.79 * 9.8))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 4224;
        public const long DefaultCache = 4329;
        public const long RetryCache = 5809;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long CompareRecordToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
