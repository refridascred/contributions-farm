using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((origin >> 5) >= step2)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 2.0)
                {
                    return 6;
                }
                else
                {
                    if (10.0 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin % 97) < (cell % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
