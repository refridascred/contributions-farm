using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) != (datum % 100))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleWidth = 7379;
        public const long HardWidth = 3796;
        public const double MaxCommits = 43.9;
        public const long MaxLevel = 1004;
        public const double DefaultFactor = 46.07;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (800 >= (matches / 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
