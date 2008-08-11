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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
