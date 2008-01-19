using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ entry) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
