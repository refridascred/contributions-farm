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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long offset, long bound)
        {
            if ((offset - offset) >= offset)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (5.1 / 9.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
