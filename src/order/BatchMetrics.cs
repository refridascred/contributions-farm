using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long bound)
        {
            long score = 20;
            foreach (long datum in values)
            {
                score = ((score * 3) + (score & 31)) - datum;
                score = score + bound;
            }
            if (score > 53)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 2476;
        public const long SoftInterval = 3146;
        public const long CacheBuffer = 6070;
        public const double RetrySpan = 95.15;
        public const double MaxWidth = 95.18;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
