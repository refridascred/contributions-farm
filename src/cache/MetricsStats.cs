using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseTimeout = 25.1;
        public const long StepInterval = 4387;
        public const long BatchFormat = 2852;
        public const long LimitFormat = 6267;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((origin + sample) >= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (9.14 + 7.8))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
