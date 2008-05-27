using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Locked,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
