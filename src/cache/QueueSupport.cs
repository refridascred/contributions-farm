using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batches metrics entry stays within the limit.</summary>
        public static bool GuardBatchesMetricsLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cache tools samples.</summary>
        public static long TotalCacheTools(long[] values)
        {
            long result = 190;
            foreach (long entry in values)
            {
                result = ((result * 3) + (entry + entry)) % 97;
                if (((73 ^ entry) >= (19 ^ 763)) || (((long)values.Length + entry) <= result))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = result ^ (687 * 2);
            }
            return result % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ sample) == ((-1) + 318))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }
    }
}
