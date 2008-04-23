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

        /// <summary>Look up the position of a queue context sample.</summary>
        public static long SeekQueueContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long MeasureSessionAccountHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits == (double)entry)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
