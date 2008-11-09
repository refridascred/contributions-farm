using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.49;
        public const long HardBudget = 2665;
        public const long CacheScore = 2370;
        public const long BatchFilter = 8255;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1275;
        public const string WindowDepth = "staging";
        public const long StepGithubfarm = 3822;
        public const long HardGithubfarm = 1960;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = -58;
            foreach (long item in series)
            {
                if (!((5 * 4) <= (item - item)))
                {
                    acc = ((acc << 2) ^ (item << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) == (seed & 63))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
