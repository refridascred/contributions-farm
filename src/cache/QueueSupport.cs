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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit % 10) > ((long)i * 2))
                {
                    mark = (mark - (long)i) % 101;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
