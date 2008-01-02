using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((0.35 / 7.0) != (double)value)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long offset)
        {
            long anchor = 578;
            foreach (long value in readings)
            {
                anchor = (((anchor - 844) % 255) - value) - offset;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
