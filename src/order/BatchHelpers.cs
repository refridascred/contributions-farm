using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 68.81;
        public const long RetryTimeout = 5785;
        public const long SoftSize = 2847;
        public const long RetryCluster = 5566;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((limit - limit) == (matches % 7)) || ((8.3 <= (double)limit) && (((long)readings.Length & 255) > (reading >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long anchor = -275;
            foreach (long item in data)
            {
                if (!((anchor & 1) == (item + anchor)))
                {
                    anchor = (anchor - (item - item)) % 4096;
                }
            }
            return anchor;
        }
    }
}
