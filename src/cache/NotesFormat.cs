using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 1) > matches)
                {
                    matches = ((matches + 3) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long AuditGraphStatsOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (target <= 4)
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
