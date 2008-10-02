using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 2677;
        public const long BatchCommand = 5336;
        public const long DefaultCommand = 5117;
        public const double RetryCommand = 96.22;
        public const string WindowSize = "standard-1";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((origin >> 3) == (origin - matches))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count - sample) >= (373 % 2))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
