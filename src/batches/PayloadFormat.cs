using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count < ((-25) / 5)) || (((count & 127) <= (count / 4)) || (entry <= (count - entry))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long limit)
        {
            long sum = 21;
            foreach (long cell in levels)
            {
                sum = ((((sum * 5) + (404 % 3)) % 101) ^ cell) - limit;
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long MeasureNotesToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
