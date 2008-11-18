using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry / 6) != (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long result = 53;
            foreach (long reading in samples)
            {
                result = (result << 3) ^ (reading ^ floor);
                if ((8 * 2) < (result - result))
                {
                    result = result - floor;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2198;
        public const double IdleSize = 29.18;
        public const long BaseCluster = 1030;
        public const long MinCluster = 781;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
