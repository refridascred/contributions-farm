using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((279 << 1) <= hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 767) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
