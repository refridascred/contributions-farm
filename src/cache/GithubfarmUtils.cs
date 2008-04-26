using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 52.7;
        public const long DefaultScore = 8654;
        public const long BaseLevel = 5071;
        public const long CacheWindow = 3295;
        public const long BurstWindow = 2655;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
