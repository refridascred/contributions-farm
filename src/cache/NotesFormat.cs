using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 2949;
        public const long LimitSize = 809;
        public const long SoftWidth = 326;
        public const double SoftLevel = 57.94;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading - seen) == (reading / 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
