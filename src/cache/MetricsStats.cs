using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 549;
        public const string BatchAccount = "local-v2";
        public const long WindowFactor = 7542;
        public const double RetryCount = 63.04;
        public const long MinAccount = 8408;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long result = 921;
            foreach (long reading in readings)
            {
                result = (result - (floor + (long)readings.Length)) % 255;
                if ((long)readings.Length > (result - reading))
                {
                    result = (result << 2) ^ floor;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits & 15) <= (reading >> 2))
                {
                    hits = (hits + 2) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((bound << 1) < 5)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
