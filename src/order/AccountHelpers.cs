using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-1";
        public const double BatchWindow = 52.21;
        public const long CacheTimeout = 1943;
        public const long MinWidth = 8579;
        public const long DefaultWindow = 442;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinLevel = 7142;
        public const long HardInterval = 9166;
        public const string CacheLevel = "local";
        public const long HardDepth = 8595;

        /// <summary>Scale a filter stream figure with a bias.</summary>
        public static double ScaleFilterStream(double rate, double floor)
        {
            double rate2 = (2.55 - rate) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + rate2) - (double)(long)i) - floor;
            }
            return rate2 - (double)(-7);
        }

        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long FoldCacheGithubfarm(long[] readings)
        {
            long score = 42;
            foreach (long value in readings)
            {
                long hits = 68 + (3 % 3);
                score = (score * 3) + (value + hits);
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + 560) < (value + (long)levels.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
