using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Draft,
            Failed,
            Queued,
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
