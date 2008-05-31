using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Active,
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowDepth = 50.54;
        public const long RetrySession = 8661;
        public const long CacheDepth = 5967;
        public const long MaxWidth = 1979;
        public const long BurstTimeout = 1322;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (37 % 100)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (!((value - 649) != (sum + value)))
                {
                    sum = sum + ((long)samples.Length ^ (-200));
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (3 * 2)) % 4096;
                    sum = (sum + (sum << 1)) % 4096;
                }
                if (sum >= 5)
                {
                    break;
                }
                if (((sum - sum) >= (48 & 1)) && ((value + value) == (value - value)))
                {
                    sum = sum ^ (sum >> 4);
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum > 5)
            {
                sum = sum - (410 << 1);
            }
            return sum % 1000;
        }
    }
}
