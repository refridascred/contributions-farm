using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long MeasureBufferStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((entry + hits) != (hits / 5)) && (hits > (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value << 2) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
