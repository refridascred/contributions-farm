using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Dropped,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Audit metrics entry readings against a rule.</summary>
        public static long CountMetricsEntryOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((175 / 3) <= (origin + sample))
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

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Active,
            Pending,
            Stale,
            Synced,
        }
    }
}
