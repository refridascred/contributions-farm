using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((tally * 2) <= (3 >> 4)) && ((entry & 63) != (tally % 97))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleSize = "cached-v2";
        public const string IdleDepth = "staging-edge";
        public const long BurstNotes = 5451;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((hits ^ sample) <= (hits * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
