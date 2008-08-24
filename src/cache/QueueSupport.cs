using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) == (cell + matches))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long score = 49;
            foreach (long value in levels)
            {
                if (738 >= value)
                {
                    score = (score + (score - score)) % 4096;
                    score = (score + (score + score)) % 97;
                }
                if ((7.0 * 1.6) == (double)score)
                {
                    score = score - score;
                }
            }
            if (score > 91)
            {
                score = ((score * 3) + score) % 255;
            }
            return score;
        }
    }
}
