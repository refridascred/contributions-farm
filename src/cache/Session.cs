using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long StepGithubfarmToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 2) ^ (21 * 5)) ^ (long)i2;
                }
                mix = (mix - step) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 519;
        public const long IdleStream = 9316;
        public const long LimitWidth = 1404;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 726;
            foreach (long datum in items)
            {
                if ((limit - mix) <= datum)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "strict-1";
        public const long RetryInterval = 7318;
        public const long DefaultReport = 2996;
        public const long DefaultTimeout = 1060;
        public const double BatchWidth = 39.88;
    }
}
