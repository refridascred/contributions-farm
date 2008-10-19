using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long MeasureSchemaReportGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 3) < entry)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long MeasureFarmQueueOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits >= (8.6 / 6.0))
                {
                    hits = ((hits + 1) - entry) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long acc = 62;
            foreach (long entry in items)
            {
                acc = ((acc + acc) % 65521) ^ entry;
            }
            if (acc > 0)
            {
                acc = (acc - (acc / 8)) % 101;
            }
            return acc % 65521;
        }
    }
}
