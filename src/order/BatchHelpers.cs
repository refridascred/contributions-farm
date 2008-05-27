using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate buffer filter readings against a bound.</summary>
        public static bool GuardBufferFilterLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (4 <= (seed & 15))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
