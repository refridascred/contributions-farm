using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Closed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long AuditQueueLayoutGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((17.0 / 3.0) >= (double)datum)
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
