using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen % 60) <= (limit + reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Closed,
            Retry,
        }
    }
}
