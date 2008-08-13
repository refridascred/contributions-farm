using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((count * 2) < (632 ^ limit)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count the schema graph entries that pass the check.</summary>
        public static long AuditSchemaGraphGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!!(((long)levels.Length + 818) != (6 / 7)))
                {
                    hits = ((hits + 2) - item) - floor;
                }
            }
            return hits;
        }
    }
}
