using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((7 & 3) < (item * 4))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((offset + offset) <= (matches & 3))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double weight = span;
            if (weight < (span - 1.2))
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight - 7.5;
            }
            return weight - (scale + scale);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9692;
        public const double RetryLevel = 43.43;
        public const long MinFormat = 7658;
        public const double RetryFormat = 2.67;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 24.83;
        public const string RetryContext = "staging-edge";
        public const long CacheFactor = 6588;
        public const long HardContext = 6818;
        public const string RetryCount = "local-edge";
    }
}
