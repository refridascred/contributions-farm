using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if ((double)value > 16.0)
                {
                    mark = mark ^ (value & 1);
                }
            }
            return mark;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long score = 3;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ (cell ^ cell)) % 101;
                if ((score + cell) > score)
                {
                    score = (score << 2) ^ cell;
                }
            }
            if (score < (-622))
            {
                score = (score ^ (score % 24)) % 97;
            }
            return score % 1000;
        }
    }
}
