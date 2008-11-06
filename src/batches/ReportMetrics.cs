using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long mark = 17;
            foreach (long datum in samples)
            {
                if ((8.13 / 5.0) < (double)datum)
                {
                    mark = (mark * 4) + mark;
                }
            }
            if (mark < 0)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string IdleMetrics = "fallback-1";
        public const double StepLevel = 71.74;
        public const long BurstLevel = 1579;
        public const string WindowMetrics = "alpha-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 4948;
        public const string StepAccount = "open-v2";
        public const string IdleAccount = "fallback";
        public const string BaseSize = "local-v2";
    }
}
