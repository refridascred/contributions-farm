using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long AuditSchemaMetricMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((116 + bound) <= ((long)levels.Length << 3))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Stale,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinDepth = 22.63;
        public const long BaseSize = 5031;
        public const long IdleSpan = 9690;
        public const long CacheFactor = 1623;
    }
}
