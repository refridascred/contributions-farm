using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((0.4 / 8.0) >= (double)seen))
                {
                    seen = ((seen + 1) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (6 - 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
