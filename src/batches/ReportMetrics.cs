using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((2.4 + 11.0) >= (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long CombineMetricsSchema(long[] data, long floor)
        {
            long state = 302;
            foreach (long item in data)
            {
                state = ((state + (3 - item)) % 97) - floor;
                if ((double)state <= (20.0 * 4.82))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Failed,
            New,
        }
    }
}
