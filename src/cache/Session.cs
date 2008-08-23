using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepLevel = 4011;
        public const double LimitBuffer = 41.05;
        public const double MinSize = 10.25;
        public const long StepBuffer = 1310;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 76.69;
        public const long HardBudget = 5736;
        public const long DefaultRatio = 90;
        public const long BatchFactor = 4974;
        public const string IdleScore = "standard-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Failed,
            Closed,
        }
    }
}
