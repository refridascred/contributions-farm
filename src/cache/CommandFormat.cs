using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Paused,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepLevel = 2667;
        public const long DefaultFormat = 6622;
        public const long MaxWidth = 5571;
        public const string BurstFormat = "open-1";

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long TallyMetricsAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)value != (double)matches) || ((matches + value) < (30 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((585 + item) > (hits >> 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
