using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long CountQueueFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (7.2 > (double)target)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1064;
        public const long BaseGraph = 1841;
        public const long RetryInterval = 4248;

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 46.04;
        public const string BatchBatches = "primary-v2";
        public const long BurstBudget = 4990;
        public const long CacheInterval = 4090;

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchWidth = 9.38;
        public const long MinCount = 1227;
        public const string BatchGithubfarm = "cached-edge";
        public const string MaxGithubfarm = "primary-v2";
    }
}
