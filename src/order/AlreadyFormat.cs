using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardInterval = 85.59;
        public const double DefaultCache = 89.67;
        public const long SoftCache = 8824;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + 71) < matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
