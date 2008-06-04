using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryScore = "local";
        public const long BatchScore = 1692;
        public const string CacheCount = "stable-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((107 * 5) == (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
