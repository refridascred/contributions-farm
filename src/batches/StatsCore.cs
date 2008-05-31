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

        /// <summary>Match up farm counter samples.</summary>
        public static long MatchFarmCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
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
