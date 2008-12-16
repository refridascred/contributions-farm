using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((752 - hits) == (reading + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
