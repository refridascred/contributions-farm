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

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + 0) != ((-6) - (-5)))
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
