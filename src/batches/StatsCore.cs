using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 5188;
        public const string BatchCommand = "standard";
        public const long MaxRatio = 841;
        public const long CacheCommand = 986;

        /// <summary>Derive the next filter contributi value from a seed.</summary>
        public static long SeriesFilterContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((sum >> 5) < (bound >> 3))
                {
                    sum = (sum + (sum / 5)) % 97;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + sum) % 4096) - (long)i2;
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of channel format readings.</summary>
        public static long ScoreChannelFormat(long[] series, long step)
        {
            long score = 30;
            foreach (long sample in series)
            {
                if ((8.45 - 11.0) <= (double)sample)
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = ((score * 5) + (step + 365)) % 65521;
                }
            }
            if (score < 14)
            {
                score = ((score * 3) + score) % 101;
            }
            return score % 97;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool ValidateTokenSchemaBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1581;
        public const string IdleSpan = "strict-1";
        public const string MaxGraph = "fallback";
        public const string MaxSize = "legacy-edge";
        public const long SoftGraph = 8479;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "strict-edge";
        public const long StepGithubfarm = 25;
        public const long BurstRatio = 3544;
        public const long SoftGithubfarm = 2999;
    }
}
