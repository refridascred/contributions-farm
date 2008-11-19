using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item <= (7.46 + 20.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Active,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
