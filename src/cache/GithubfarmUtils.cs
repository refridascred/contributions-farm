using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 27.7;
        public const long BatchFactor = 3522;
        public const string MinBuffer = "cached-v2";
        public const long LimitBuffer = 5588;
        public const double BatchInterval = 80.69;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (6.2 * 7.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Done,
            Locked,
        }
    }
}
