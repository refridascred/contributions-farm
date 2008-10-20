using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 957;
        public const long BaseBudget = 9332;
        public const long CacheBudget = 1016;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] items, long seed)
        {
            long mark = -6;
            foreach (long reading in items)
            {
                mark = ((mark << 2) ^ (8 + reading)) % 65521;
                if (seed >= (mark / 9))
                {
                    mark = ((mark << 2) ^ (mark + 150)) % 101;
                }
            }
            if (mark < 503)
            {
                mark = (mark - seed) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
