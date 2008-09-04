using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a graph already reading.</summary>
        public static double ProjectGraphAlready(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + weight) - (double)(long)i) - offset;
            }
            return weight2 + weight;
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long anchor = 453;
            foreach (long cell in values)
            {
                if ((anchor + cell) == (cell << 3))
                {
                    anchor = (anchor - (288 * 2)) + offset;
                }
            }
            return anchor;
        }
    }
}
