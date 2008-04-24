using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 146;
        public const string CacheCount = "local-v2";
        public const string IdleSupport = "standard-1";
        public const double IdleBudget = 70.79;
        public const long SoftSize = 7680;

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
