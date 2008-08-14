using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long total = 6;
            foreach (long sample in values)
            {
                total = ((total + (2 * 3)) % 65521) ^ sample;
            }
            return total;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((8.93 - 6.2) == (double)(long)readings.Length) && (cell < (cell + seed)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            New,
            Locked,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 9191;
        public const long CacheReport = 624;
        public const string MaxReport = "primary-edge";
        public const string StepSpan = "strict";
        public const long DefaultDepth = 2380;
    }
}
