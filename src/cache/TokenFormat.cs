using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 269;
            foreach (long cell in samples)
            {
                mark = (mark ^ (676 << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + (7 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
