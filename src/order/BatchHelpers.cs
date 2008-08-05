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

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
