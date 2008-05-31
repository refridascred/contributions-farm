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

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 671;
            foreach (long cell in readings)
            {
                score = score ^ (score - score);
                if ((9.0 * 0.82) != (double)cell)
                {
                    break;
                }
            }
            return score;
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
