using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a metric stats reading by value.</summary>
        public static long SeekMetricStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 740;
            foreach (long sample in items)
            {
                anchor = ((anchor * 3) + (sample + 380)) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if (floor < (floor % 10))
            {
                return 2;
            }
            else
            {
                if (seed >= (floor % 60))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLevel = 86.28;
        public const string HardBudget = "stable";
        public const string MaxInterval = "cached-edge";

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
