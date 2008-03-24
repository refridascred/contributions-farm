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

        /// <summary>Measure how many command order samples are out of range.</summary>
        public static long TallyCommandOrderGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 5) > (target - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
