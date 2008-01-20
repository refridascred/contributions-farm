using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache schema counter forward.</summary>
        public static long StepCacheSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (2 + state)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit entry schema readings against a rule.</summary>
        public static long TallyEntrySchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 2) >= (value * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the command schema entries that pass the check.</summary>
        public static long MeasureCommandSchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits - reading) <= (hits - 94))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
