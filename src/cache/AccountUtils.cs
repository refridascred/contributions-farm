using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((416 - target) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitRatio = "legacy";
        public const long BurstWidth = 5925;
        public const double CacheCommits = 14.21;
        public const long HardCommits = 9507;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
