using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit stats editor readings against a rule.</summary>
        public static long TallyStatsEditorGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (4.53 <= (double)step)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] values)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if ((score + score) >= (datum + datum))
                {
                    score = ((score * 4) + (datum + datum)) % 1000;
                }
                else
                {
                    score = score ^ (48 + score);
                }
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 65521;
        }
    }
}
