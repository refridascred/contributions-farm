using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank schema stats input into a small class.</summary>
        public static long ClassifySchemaStats(long origin, long bound)
        {
            if (((bound * 2) <= origin) && ((double)bound < (11.0 + 7.0)))
            {
                return 3;
            }
            else
            {
                if (bound <= origin)
                {
                    return 8;
                }
                else
                {
                    if (origin > (bound - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ bound) == (origin << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream payload samples.</summary>
        public static long CompareStreamPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long MeasureStatsNotesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 4) >= matches)
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
