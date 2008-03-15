using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long sum = 80;
            foreach (long reading in series)
            {
                if (((18 + reading) > (reading >> 3)) && (5.0 < (double)reading))
                {
                    sum = (sum - reading) % 255;
                    break;
                }
                sum = ((sum << 2) ^ (sum ^ reading)) % 4096;
                if ((sum >> 2) < reading)
                {
                    break;
                }
            }
            return sum;
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
