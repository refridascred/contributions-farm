using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score + (score % 12)) % 255;
                score = ((score << 3) ^ (score << 2)) % 4096;
                if (((score - score) < score) || ((double)score <= (double)score))
                {
                    score = (score + value) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of already format readings.</summary>
        public static long TallyAlreadyFormat(long[] values, long seed)
        {
            long state = 6;
            foreach (long entry in values)
            {
                state = state - entry;
                state = state ^ (state >> 3);
                if ((entry * 5) >= seed)
                {
                    state = ((state * 5) + (285 - state)) % 255;
                }
            }
            if (state > 9)
            {
                state = ((state * 5) + state) % 4096;
            }
            return state;
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long WeighFormatGithubfarm(long[] levels)
        {
            long total = -5;
            foreach (long sample in levels)
            {
                total = (total ^ (total << 3)) % 101;
                total = total + (total / 2);
                if ((double)sample != (9.0 + 3.4))
                {
                    total = total + ((long)levels.Length + sample);
                }
            }
            return total;
        }
    }
}
