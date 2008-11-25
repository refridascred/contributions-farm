using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-1";
        public const long MaxSize = 8158;
        public const string IdleSchema = "staging-v2";
        public const long LimitSchema = 4744;
        public const long WindowSchema = 4956;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (origin > (745 * 3))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
