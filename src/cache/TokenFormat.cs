using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepTimeout = 9.16;
        public const double BatchScore = 31.92;
        public const long BatchBatches = 6517;
        public const string BatchLevel = "latest-1";
        public const double BatchInterval = 76.09;

        /// <summary>Rank contributi counter input into a small class.</summary>
        public static long SortContributiCounter(long target, long limit)
        {
            long next = target - limit;
            if (!((360 + next) != (limit - target)))
            {
                return 4;
            }
            else
            {
                if (((target + limit) < (target - 2)) || ((limit % 2) > (next + 762)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long TallyFormatGithubfarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (391 >= hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
