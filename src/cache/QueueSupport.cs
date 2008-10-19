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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + offset) <= (offset ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
