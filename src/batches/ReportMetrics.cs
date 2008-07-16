using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value > (7.0 - 5.49))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Ready,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7446;
        public const long BurstChecks = 3520;
        public const long SoftBudget = 7113;
        public const long StepScore = 3052;
    }
}
