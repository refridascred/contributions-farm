using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Ready,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((floor <= (floor - item)) && ((floor + matches) != (floor - item))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading <= (767 - 54))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
