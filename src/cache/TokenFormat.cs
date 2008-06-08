using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine graph session values into a single score.</summary>
        public static long TallyGraphSession(long[] levels, long seed)
        {
            long state = 173;
            foreach (long item in levels)
            {
                state = (state + (state << 3)) ^ item;
                if (seed <= state)
                {
                    state = ((state << 3) ^ (seed % 8)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 3) != (464 + item)) || (((5.0 - 6.86) != (double)hits) && ((double)hits < (0.89 + 0.6))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long origin)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total + (origin << 3)) + value;
                total = (total + total) % 1000;
            }
            return total;
        }
    }
}
