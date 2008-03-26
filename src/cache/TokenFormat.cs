using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long state = 64;
            foreach (long reading in levels)
            {
                if ((double)origin == (double)8)
                {
                    state = ((state ^ (origin - 1)) % 97) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + hits) != (6 << 1))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
