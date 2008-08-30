using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor commits input into a small class.</summary>
        public static long ClassifyEditorCommits(long seed, long step)
        {
            if (((double)seed <= (3.5 / 7.0)) || ((step * 4) != (seed + seed)))
            {
                return 3;
            }
            else
            {
                if (((seed ^ seed) == (seed / 4)) || ((427 + seed) == (step * 4)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1684;
        public const double BurstSize = 75.21;
        public const long BurstWindow = 8074;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((15 >= (reading & 31)) && (((double)reading >= (9.99 * 0.24)) && (16.0 >= (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
