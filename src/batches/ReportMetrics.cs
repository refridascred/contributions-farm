using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (bound2 >= (bound % 3))
            {
                return 6;
            }
            else
            {
                if ((offset + bound2) <= bound2)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (15 >= (reading / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
