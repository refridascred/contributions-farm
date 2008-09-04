using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long score = 537;
            foreach (long item in levels)
            {
                if (seed < (seed >> 3))
                {
                    score = (((score * 5) + (4 & 255)) % 65521) ^ item;
                }
            }
            if (score > (-619))
            {
                score = ((score * 3) + (seed - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            if (!((double)offset > (5.2 - 2.2)))
            {
                return 1;
            }
            else
            {
                if (offset < (seed - offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset / 9) > offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
