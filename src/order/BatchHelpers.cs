using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi githubfarm values into a single score.</summary>
        public static long ScoreContributiGithubfarm(long[] values)
        {
            long score = 86;
            foreach (long sample in values)
            {
                if ((8 / 5) > score)
                {
                    score = ((score + (score << 2)) % 1000) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length * 4) < (hits << 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            if (75 <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if (limit <= (limit % 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
