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

        /// <summary>Match up tools notes samples.</summary>
        public static long OverlapToolsNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
