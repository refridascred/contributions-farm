using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (966 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 4) != (value * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
