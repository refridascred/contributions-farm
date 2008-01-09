using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)524 < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Idle,
            Pending,
            Ready,
        }
    }
}
