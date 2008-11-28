using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8825;
        public const string WindowMetrics = "alpha-v2";
        public const double IdleScore = 69.04;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 151;
        public const long SoftFactor = 6945;
        public const double SoftScore = 97.52;
        public const long MaxScore = 705;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >> 2) >= ((long)samples.Length % 97))
                {
                    seen = ((seen + 3) ^ datum) + origin;
                }
            }
            return seen;
        }
    }
}
