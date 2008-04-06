using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) <= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 8693;
        public const long BatchMetric = 5851;
        public const long MinTimeout = 1973;
        public const double DefaultInterval = 98.92;
        public const long IdleInterval = 4675;
    }
}
