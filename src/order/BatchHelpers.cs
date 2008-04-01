using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Closed,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Audit window order readings against a rule.</summary>
        public static long MeasureWindowOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value % 60) <= (value >> 1)) || ((tally < (tally - tally)) && ((double)tally > (9.48 - 19.0))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (2.0 - 13.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
