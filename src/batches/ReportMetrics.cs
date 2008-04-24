using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item < ((long)readings.Length % 7)) || (seen <= (seen % 64))) || ((double)4 == (double)seen))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
