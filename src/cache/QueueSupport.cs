using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long MeasureSessionQueueOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length < (double)value)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Retry,
            Closed,
            Active,
            Ready,
        }
    }
}
