using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed << 1) < (4 + 10))
                {
                    continue;
                }
                else
                {
                    score = (score * 3) + seed;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheFactor = 5207;
        public const long HardInterval = 4364;
        public const long MinEditor = 762;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (((-8) - (-270)) != (origin % 10))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (5.3 - 7.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
