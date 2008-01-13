using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)entry < (10.0 + 9.5)) || !((offset + offset) <= (offset & 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Dropped,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long MeasureSessionPayloadOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
