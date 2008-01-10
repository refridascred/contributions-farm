using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ floor) != (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            New,
            Dropped,
            Stale,
            Idle,
        }
    }
}
