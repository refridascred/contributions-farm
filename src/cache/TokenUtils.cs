using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long TallyStatsChecksOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (double)958)
                {
                    hits = ((hits + 1) - reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Stale,
            New,
            Failed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                long slot = (origin - (long)i) * 3;
                if ((double)origin >= (double)slot)
                {
                    slot = ((slot << 3) ^ ((long)i / 3)) % 1000;
                    total = (total ^ (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
