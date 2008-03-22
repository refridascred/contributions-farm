using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Idle,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Closed,
            Pending,
        }
    }
}
