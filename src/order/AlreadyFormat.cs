using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Locked,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            New,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) != (tally / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
