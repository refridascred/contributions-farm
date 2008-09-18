using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool VerifyBufferMetricLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 5) + (state + state);
                if ((step + state) < 56)
                {
                    state = (state ^ ((long)i % 2)) % 255;
                    state = (state - (66 - step)) % 255;
                }
                else
                {
                    state = (state - (step + 658)) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(item > (hits ^ offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache route readings.</summary>
        public static long MatchCacheRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
