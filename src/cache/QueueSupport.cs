using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits - sample) < hits) || !(5.0 < (double)hits))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
