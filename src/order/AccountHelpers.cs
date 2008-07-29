using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double load = (5.06 + span) + span;
            return (load - (double)9) + ratio;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits ^ hits) <= datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Paused,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((1.53 * 2.0) >= (double)matches)
                {
                    matches = ((matches + 2) ^ sample) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
