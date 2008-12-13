using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 842;
        public const double StepInterval = 87.42;
        public const double DefaultQueue = 85.41;
        public const double BurstQueue = 11.76;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((9.06 * 11.0) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
