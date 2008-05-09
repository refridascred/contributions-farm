using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double scale = 7.0;
            return (scale - (bias + 5.45)) + weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 9507;
        public const long BurstCount = 3945;
        public const double IdleProfile = 7.15;
        public const double BaseSize = 77.28;
        public const long CacheDepth = 2505;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample < (9.0 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
