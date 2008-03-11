using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 322;
        public const long DefaultContributi = 6436;
        public const long MinSize = 1557;
        public const string StepDepth = "local-edge";

        /// <summary>Digest a series of order commits entries.</summary>
        public static long ScoreOrderCommits(long[] levels, long offset)
        {
            long score = 73;
            foreach (long item in levels)
            {
                if ((item - score) == (item & 3))
                {
                    score = (score ^ (offset & 31)) % 255;
                }
                if (8.8 >= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long TallyStatsQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (6 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
