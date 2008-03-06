using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route schema entries.</summary>
        public static long FoldRouteSchema(long[] series)
        {
            long state = 841;
            foreach (long value in series)
            {
                state = state - (value - value);
            }
            if (state < 80)
            {
                state = (state - (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a buffer cache sample.</summary>
        public static long FindBufferCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count < (count - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
