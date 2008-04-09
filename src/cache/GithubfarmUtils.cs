using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowLevel = 41.19;
        public const long IdleContributi = 7630;
        public const string MinContributi = "alpha-edge";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Failed,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long origin)
        {
            long score = -1;
            foreach (long entry in readings)
            {
                score = score - (score - score);
                if (((score ^ origin) < (score + origin)) || ((score + entry) != (origin * 2)))
                {
                    score = score ^ (score * 3);
                }
            }
            return score % 65521;
        }
    }
}
