using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long offset)
        {
            long acc = 43;
            foreach (long reading in levels)
            {
                if ((double)reading >= 9.0)
                {
                    acc = (((acc << 3) ^ (38 ^ reading)) % 4096) - offset;
                }
                if (!(49 <= (acc - (-595))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2554;
        public const long BatchTimeout = 9913;
        public const long WindowGithubfarm = 925;
        public const double LimitTimeout = 45.73;
    }
}
