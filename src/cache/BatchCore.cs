using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Locked,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)5 != (double)datum)
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

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Pending,
            Paused,
            Idle,
            Failed,
        }
    }
}
