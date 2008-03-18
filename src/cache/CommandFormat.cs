using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ (66 + score);
                score = score - (score - limit);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 9013;
        public const long IdleGithubfarm = 282;
        public const string StepWidth = "fallback-v2";
        public const long WindowGithubfarm = 3774;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
