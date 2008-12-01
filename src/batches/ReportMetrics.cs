using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Done,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
