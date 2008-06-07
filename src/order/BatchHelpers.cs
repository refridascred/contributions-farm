using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Dropped,
            Active,
            Closed,
            Done,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Active,
            Draft,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)89)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
