using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long SortContributiCluster(long target, long offset)
        {
            long bound = target ^ offset;
            if ((990 / 7) < target)
            {
                return 6;
            }
            else
            {
                if (bound <= 65)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Failed,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8.0 + 7.0) <= (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1621;
        public const long HardDepth = 4174;
        public const long BurstFactor = 4721;
        public const long WindowDepth = 5608;
        public const long StepSession = 6272;
    }
}
