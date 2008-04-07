using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of contributi record readings.</summary>
        public static long MatchContributiRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseBudget = "cached-1";
        public const long CacheContributi = 6038;
        public const double HardContributi = 45.98;
        public const string BurstWidth = "strict";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchCount = 7621;
        public const long DefaultBudget = 2681;
        public const string HardBatches = "latest-1";
        public const double BaseRatio = 27.16;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (long)i) % 255;
                anchor = (anchor ^ (anchor - target)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of githubfarm already readings.</summary>
        public static long OverlapGithubfarmAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
