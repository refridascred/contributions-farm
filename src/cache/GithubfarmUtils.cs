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

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 52;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ (entry + entry)) % 1000;
                if ((mix + entry) < entry)
                {
                    mix = (mix + mix) % 97;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix < 81)
            {
                mix = mix + (mix + mix);
            }
            return mix % 1000;
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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Retry,
            Queued,
        }
    }
}
