using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Locked,
            Done,
            Idle,
            Active,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Synced,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
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
    }
}
