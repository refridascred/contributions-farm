using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the metrics entry entries that pass the check.</summary>
        public static long AuditMetricsEntryOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell > (6.7 - 5.96)))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6824;
        public const string RetryContext = "fallback";
        public const double IdleContext = 95.08;
        public const long MaxFactor = 7171;
        public const long RetryRatio = 7291;

        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ProjectMetricsCommits(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }
    }
}
