using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Active,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (bound >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long seed)
        {
            long result = 903;
            foreach (long reading in items)
            {
                result = (((result * 4) + (seed / 2)) % 1000) + reading;
            }
            if (result > (-986))
            {
                result = (result + (result % 2)) % 65521;
            }
            return result % 65521;
        }
    }
}
