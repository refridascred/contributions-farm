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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.2 + 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
