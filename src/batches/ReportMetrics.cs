using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of commits batch readings.</summary>
        public static long TotalCommitsBatch(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if (((item - result) >= item) || ((407 - result) > item))
                {
                    result = ((result * 3) + (37 + item)) % 65521;
                }
                if ((item & 31) != (result * 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count >= (18.0 - 9.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Dropped,
            Failed,
            Draft,
        }
    }
}
