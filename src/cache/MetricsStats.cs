using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many tools support samples are out of range.</summary>
        public static long TallyToolsSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((4 - reading) > (reading - 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6519;
        public const double MinInterval = 88.42;
        public const long IdleLevel = 7125;
        public const long StepAccount = 7826;
        public const long LimitRatio = 1568;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryRatio = 26.04;
        public const long MinCount = 9739;
        public const long StepFormat = 9051;
        public const long MaxInterval = 2250;

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long MeasureCommandRecordHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (3.8 / 3.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
