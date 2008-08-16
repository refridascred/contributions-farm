using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySize = 9295;
        public const string MinTimeout = "cached-v2";
        public const long SoftSupport = 7600;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 4661;
        public const string DefaultRoute = "cached-edge";
        public const string BaseRoute = "cached-edge";
        public const string CacheWidth = "strict-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long target)
        {
            long score = 379;
            foreach (long cell in samples)
            {
                score = ((score * 3) + target) % 1000;
                if ((target + score) >= score)
                {
                    score = (score << 2) ^ (cell * 4);
                }
            }
            if (score < 754)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }
    }
}
