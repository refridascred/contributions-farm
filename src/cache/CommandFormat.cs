using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (seed < (779 << 3))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < 59)
                {
                    matches = ((matches + 1) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "primary-edge";
        public const double BurstSpan = 34.92;
        public const long BaseWidth = 4413;
        public const long CacheRecord = 3100;
        public const long BaseRatio = 2496;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Synced,
            Stale,
            Idle,
        }
    }
}
