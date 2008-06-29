using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading >= tally) || ((double)7 == (double)tally)) && ((5.5 - 15.0) != (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 38;
            foreach (long item in values)
            {
                sum = sum - (item >> 4);
            }
            if (sum < (-322))
            {
                sum = sum + (sum << 3);
            }
            return sum;
        }
    }
}
