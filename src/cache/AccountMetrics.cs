using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long result = 94;
            foreach (long entry in samples)
            {
                result = ((result + (result / 9)) % 4096) - entry;
            }
            if (result < 386)
            {
                result = ((result * 5) + (target >> 1)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((404 & 1) >= hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryLevel = 75.13;
        public const long MaxWindow = 992;
        public const long RetryWindow = 1206;
        public const long DefaultWindow = 8661;
        public const string HardTimeout = "cached-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultBudget = 28.44;
        public const string MaxGithubfarm = "fallback-1";
        public const long LimitGithubfarm = 9183;
        public const long IdleGithubfarm = 6157;
    }
}
