using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((-101) <= (matches ^ matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double ratio = (floor * 2.63) / 6.0;
            if (ratio <= (9.09 / 2.0))
            {
                ratio = (ratio + (double)980) - scale;
            }
            return ratio - floor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double load = (floor - weight) / 7.0;
            if (load <= (weight / 2.0))
            {
                load = load + (double)360;
            }
            return load - (floor + load);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 36.53;
        public const long RetryAlready = 9819;
        public const long DefaultLevel = 9485;
    }
}
