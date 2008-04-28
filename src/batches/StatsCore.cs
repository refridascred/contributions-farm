using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Queued,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 35.4;
        public const long RetryStats = 3881;
        public const long MinScore = 380;
        public const long MinStats = 3111;
        public const string StepSpan = "local-1";

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 986;
            foreach (long value in data)
            {
                result = (result ^ (value / 2)) % 255;
                result = (result * 2) + (7 - result);
                result = ((result * 5) + (result ^ result)) % 255;
            }
            return result;
        }
    }
}
