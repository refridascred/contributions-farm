using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits > (hits / 2))
                {
                    hits = ((hits + 1) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long ScoreRouteBatches(long[] samples)
        {
            long result = 27;
            foreach (long item in samples)
            {
                if ((6.32 + 4.97) >= (double)result)
                {
                    result = ((result << 2) ^ (item << 3)) % 255;
                }
            }
            if (result > 749)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
