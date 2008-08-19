using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Closed,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (bias / 6.0))
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale - 2.24)) + (double)(long)i;
            }
            return scale - 7.0;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "legacy-1";
        public const double BurstStream = 19.7;
        public const string BurstSize = "primary-edge";
        public const long WindowDepth = 7897;
        public const double HardRatio = 97.08;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((13.0 / 5.0) > (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
