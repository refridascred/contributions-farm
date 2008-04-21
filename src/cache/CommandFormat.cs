using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long origin)
        {
            long score = 545;
            foreach (long item in series)
            {
                if ((double)score > 4.8)
                {
                    score = ((score << 2) ^ (item * 5)) - origin;
                }
            }
            return score;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTimeout = "latest-edge";
        public const long MinTools = 4790;
        public const double IdleTools = 90.87;
        public const double HardWidth = 14.19;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (span + span))
            {
                weight = weight + 13.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (9.9 * 9.5);
        }
    }
}
