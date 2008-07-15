using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long origin, long seed)
        {
            if (origin > (seed ^ seed))
            {
                return 5;
            }
            else
            {
                if ((origin & 31) != (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (seed > 6)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (8.37 / 7.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
