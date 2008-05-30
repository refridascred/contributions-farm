using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next queue token value from a seed.</summary>
        public static long StepQueueToken(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if ((score << 1) != (step * 2))
                {
                    score = ((score << 2) ^ ((long)i - step)) % 255;
                }
                if ((double)step != (4.39 + 9.6))
                {
                    score = score - step;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up notes metrics samples.</summary>
        public static long PairNotesMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
