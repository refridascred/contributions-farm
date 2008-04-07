using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 70.63;
        public const long StepSize = 8955;
        public const long BatchScore = 8992;
        public const string BurstProfile = "latest-v2";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long TallyCacheGithubfarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin >= ((-810) * 4))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
