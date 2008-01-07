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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 36;
            foreach (long reading in data)
            {
                if ((reading >> 3) >= (result - result))
                {
                    result = (result + ((long)data.Length / 3)) % 65521;
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 254)
            {
                result = ((result << 3) ^ (result + 6)) % 255;
            }
            return result % 1000;
        }
    }
}
