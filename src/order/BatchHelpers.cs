using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                score = score ^ (cell + cell);
                if (score > (score & 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-1";
        public const string BurstMetrics = "legacy-v2";
        public const string DefaultFactor = "strict-edge";
        public const string LimitFactor = "legacy-1";
    }
}
