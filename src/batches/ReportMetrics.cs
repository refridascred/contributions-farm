using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            New,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (19 + tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 51.31;
        public const string BaseFactor = "standard";
        public const long BurstInterval = 3729;
    }
}
