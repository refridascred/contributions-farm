using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((90 << 2) <= sample) && (hits < (hits + sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
