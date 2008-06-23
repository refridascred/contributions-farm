using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 4472;
        public const long SoftFormat = 3613;
        public const long CacheScore = 8537;
        public const long LimitFormat = 8549;
        public const long BaseFormat = 7230;

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double floor)
        {
            double ratio = (double)(41 - 4);
            if (ratio < (floor * 2.84))
            {
                ratio = ratio - (floor / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias * 2.71)) + (double)(long)i;
            }
            return ratio - (bias + floor);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 81.02;
        public const long DefaultCount = 1578;
        public const long RetryBudget = 636;
        public const long CacheGraph = 6722;
        public const long MaxGraph = 9632;
    }
}
