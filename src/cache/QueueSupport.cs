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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long item in data)
            {
                anchor = (((anchor << 3) ^ (item * 5)) % 4096) - bound;
                if ((anchor > (anchor + item)) || ((double)25 >= (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
