using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits < (double)limit)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3981;
        public const double RetrySession = 35.7;
        public const long BatchTimeout = 8600;
        public const long MinSession = 3172;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
