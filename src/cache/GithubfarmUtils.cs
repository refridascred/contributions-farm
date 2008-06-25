using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples, long seed)
        {
            long mark = 24;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (mark / 8)) - datum;
            }
            if (mark > 745)
            {
                mark = ((mark * 4) + (seed - 7)) % 101;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 3028;
        public const long MinChannel = 935;
        public const long BatchLevel = 7141;
        public const double BatchChannel = 25.74;
        public const double LimitFactor = 54.52;

        /// <summary>Compare every pair of window command readings.</summary>
        public static long CompareWindowCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
