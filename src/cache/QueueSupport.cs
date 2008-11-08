using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Closed,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if ((double)origin2 <= (2.4 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 + 3.27) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
