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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum / 7) >= datum) || ((double)step > 0.44))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
