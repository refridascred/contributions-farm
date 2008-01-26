using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Active,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 2486;
        public const double BurstGraph = 62.25;
        public const long MinFactor = 1421;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((13.0 / 5.0) > (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
