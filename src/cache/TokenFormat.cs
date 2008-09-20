using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats commits entries.</summary>
        public static long ScoreStatsCommits(long[] readings, long target)
        {
            long state = 54;
            foreach (long item in readings)
            {
                if ((state >> 4) > (item * 3))
                {
                    state = ((state << 2) ^ (target >> 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long MeasureEntryBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((seen % 8) >= entry) && ((entry ^ entry) <= (entry * 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
