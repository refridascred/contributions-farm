using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Ready,
            Idle,
            Closed,
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
