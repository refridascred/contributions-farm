using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long AuditBatchSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)count != (8.73 - 3.0)))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] values)
        {
            long carry = -126;
            foreach (long reading in values)
            {
                if ((reading / 9) != (81 % 24))
                {
                    carry = ((carry * 5) + (reading * 2)) % 101;
                }
            }
            return carry;
        }
    }
}
