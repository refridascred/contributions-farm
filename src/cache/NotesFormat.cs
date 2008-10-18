using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Draft,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) >= (6 & 31))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double load = 18.0;
            if (load >= ratio)
            {
                load = (load - 9.6) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (load + ratio);
        }
    }
}
