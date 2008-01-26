using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinSpan = "fallback-v2";
        public const long SoftTimeout = 8787;
        public const double BurstScore = 33.51;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = mark - (origin + (long)i);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 65.08;
        public const long StepScore = 6666;
        public const string IdleCommits = "open-edge";
        public const long StepBudget = 4989;
    }
}
