using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5440;
        public const long BaseBudget = 6459;
        public const long StepDepth = 1248;
        public const double DefaultProfile = 9.84;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally / 3) == (item + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Done,
            Closed,
            Synced,
            Paused,
        }
    }
}
