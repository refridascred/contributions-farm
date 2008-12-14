using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long mark = 984;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark + 131)) ^ entry;
            }
            if (mark < 687)
            {
                mark = mark ^ (90 % 60);
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long MeasureMetricGraphGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit - 3) <= limit)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
