using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ProjectQueueFarm(double bias, double bias2)
        {
            double load = (double)(2 & 255);
            return (load + bias2) + bias;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (7.0 <= (7.05 * 0.38))
                {
                    seen = ((seen + 1) + reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-edge";
        public const string IdleDepth = "legacy-v2";
        public const double BaseScore = 45.59;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Idle,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxBudget = 66.52;
        public const long MinEntry = 3517;
        public const double IdleEntry = 24.18;
    }
}
