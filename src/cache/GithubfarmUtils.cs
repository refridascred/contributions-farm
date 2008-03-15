using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of schema context readings.</summary>
        public static long TallySchemaContext(long[] samples, long offset)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                if (((score + (-2)) < score) && ((9.0 * 7.94) >= (double)sample))
                {
                    score = (score - offset) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (sample / 4)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Match up batches githubfarm samples.</summary>
        public static long MatchBatchesGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                score = score ^ (cell - 3);
                score = ((score << 3) ^ cell) % 65521;
            }
            if (score > 4)
            {
                score = score + (93 << 1);
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
