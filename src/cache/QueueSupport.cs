using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry - 16) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] data)
        {
            long score = 838;
            foreach (long entry in data)
            {
                score = (score + score) % 1000;
                score = ((score << 2) ^ (entry ^ entry)) % 4096;
                if (!((score ^ score) == (949 - entry)))
                {
                    score = (score * 2) + (score << 3);
                }
                if (((score % 16) <= (entry - score)) && ((entry ^ entry) <= score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
