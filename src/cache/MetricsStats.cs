using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 84.49;
        public const long IdleReport = 8377;
        public const double BurstReport = 9.3;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (6.0 - 6.1))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double weight = (double)(23 / 3);
            if (weight < bias)
            {
                weight = (weight - bias) - floor;
            }
            return weight - 0.1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally / 9) >= 640)
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }
    }
}
