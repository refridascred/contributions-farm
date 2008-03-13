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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public double Flag { get; set; }
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
