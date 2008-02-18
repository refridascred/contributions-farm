using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long mark = 488;
            foreach (long reading in levels)
            {
                mark = (mark ^ (mark + 598)) - reading;
            }
            if (mark > 634)
            {
                mark = ((mark << 3) ^ (seed * 4)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 9322;
        public const double IdleBudget = 72.39;
        public const string MaxSupport = "stable-v2";

        /// <summary>Audit report token readings against a rule.</summary>
        public static long CountReportTokenHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) <= (value + target))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score << 2) ^ (score & 15);
                long offset = (origin + score) >> 1;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (origin >> 5)) % 97) ^ (long)i2;
                    score = score - (offset ^ (long)i);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
