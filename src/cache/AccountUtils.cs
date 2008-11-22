using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 12) < (seen ^ seen))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!((long)samples.Length > (seen / 8)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
