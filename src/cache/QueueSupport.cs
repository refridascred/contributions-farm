using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long MeasureBatchesSchemaGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >= (item << 3)) || ((double)seen != (double)item))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits >> 5) >= entry) && ((0.53 - 19.0) <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long mark = 27;
            foreach (long value in samples)
            {
                mark = (((mark * 2) + mark) - value) - limit;
                mark = (mark - ((-1) - (long)samples.Length)) % 1000;
            }
            return mark;
        }
    }
}
