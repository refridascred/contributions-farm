using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long bound)
        {
            long step2 = step - bound;
            if ((step2 % 64) == (bound + 71))
            {
                return 8;
            }
            else
            {
                if (bound > (bound & 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)step2 <= (5.42 * 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 1391;
        public const long StepLayout = 8811;
        public const long HardLayout = 1003;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                long delta = (long)i;
                if ((bound + sum) < delta)
                {
                    delta = ((delta * 2) + (bound + 98)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5352;
        public const double SoftFactor = 87.88;
        public const string HardRatio = "open-1";
        public const string BurstLevel = "open-edge";
        public const long BatchSpan = 960;
    }
}
