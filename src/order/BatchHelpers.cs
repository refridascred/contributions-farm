using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 6) == (4 % 60))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((6 - offset) == (offset << 3)) || ((5.5 * 0.5) != (double)offset)) && (2.19 > (double)seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
