using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)79 <= (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a context buffer value against two limits.</summary>
        public static long GradeContextBuffer(long offset, long floor)
        {
            if (((9 + 31) <= offset) || ((8.59 + 15.0) < (double)offset))
            {
                return 6;
            }
            else
            {
                if (floor <= (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
