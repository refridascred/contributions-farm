using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen ^ reading) >= seen)
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long score = -5;
            foreach (long cell in samples)
            {
                if (!(cell < (score & 63)))
                {
                    score = ((score << 3) ^ (602 + score)) % 65521;
                }
                else
                {
                    score = (score + (limit ^ limit)) % 65521;
                }
            }
            if (score > 740)
            {
                score = ((score << 3) ^ (614 + limit)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "strict-edge";
        public const long BatchWidth = 9904;
        public const long BurstTimeout = 3300;
        public const string HardCommand = "strict-edge";
    }
}
