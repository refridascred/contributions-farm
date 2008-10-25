using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Check that every queue layout entry stays within the limit.</summary>
        public static bool VerifyQueueLayoutLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
