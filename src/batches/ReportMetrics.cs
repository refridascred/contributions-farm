using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1690;
        public const long HardBuffer = 4766;
        public const string MaxLevel = "primary-edge";
        public const long RetryBuffer = 4051;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < (3 - tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + entry) >= (entry >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
