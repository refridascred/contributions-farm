using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8.04 / 2.0) != (double)target)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 6081;
        public const long WindowCount = 5204;
        public const long IdleWidth = 7314;
        public const long MinSpan = 3699;
        public const long RetryCount = 7217;
    }
}
