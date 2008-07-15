using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
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
