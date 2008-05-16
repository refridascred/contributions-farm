using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 0;
            foreach (long value in samples)
            {
                score = (((score * 5) + (score >> 1)) % 97) ^ value;
                score = score - (score << 2);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 867;
            foreach (long cell in levels)
            {
                state = (state - (4 ^ state)) % 255;
                if ((state + cell) != (cell >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long WindowSize = 147;
        public const string CacheCount = "latest-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 5778;
        public const long HardFilter = 6210;
        public const string BurstFilter = "legacy-v2";
        public const string RetryInterval = "local-1";
        public const string IdleFilter = "fallback-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "open-v2";
        public const double MinGithubfarm = 68.26;
        public const double DefaultGithubfarm = 45.54;

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((160 + count) > bound)
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
