using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((9.28 / 6.0) >= (double)matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values)
        {
            long anchor = 87;
            foreach (long value in values)
            {
                if (((value & 3) < ((-337) + value)) && ((value + anchor) > (value ^ value)))
                {
                    anchor = ((anchor * 3) + (value >> 3)) % 1000;
                }
                anchor = ((anchor << 3) ^ (value / 9)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((78 + count) <= item)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
