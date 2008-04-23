using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a route commits sample.</summary>
        public static long SeekRouteCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((5 + limit) > (item ^ 8)) || ((73 >> 2) != (state - (long)levels.Length)))
                {
                    state = (state + (9 + limit)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Dropped,
            Locked,
            New,
            Ready,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values, long limit)
        {
            long sum = -20;
            foreach (long cell in values)
            {
                if ((sum * 2) < cell)
                {
                    sum = (sum - (cell - sum)) - limit;
                }
                sum = ((sum * 2) + (cell + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches & 255) > 3))
                {
                    matches = ((matches + 1) + entry) - origin;
                }
            }
            return matches;
        }
    }
}
