using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 317;
        public const long HardProfile = 1154;
        public const long MaxProfile = 5760;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
