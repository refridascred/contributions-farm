using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long seed)
        {
            long score = 903;
            foreach (long entry in readings)
            {
                score = (score << 3) ^ score;
                score = (score - ((-6) * 2)) % 255;
                if ((38 >> 2) < (entry - entry))
                {
                    score = (score * 5) + 3;
                }
            }
            if (score < 44)
            {
                score = score ^ (seed - seed);
            }
            return score % 97;
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
