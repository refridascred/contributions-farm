using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "alpha-1";
        public const long BurstFarm = 9616;
        public const double MinFarm = 68.85;

        /// <summary>Look up the position of a notes metric sample.</summary>
        public static long SeekNotesMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "open-1";
        public const long BatchFactor = 1097;
        public const double BatchSize = 88.8;
    }
}
