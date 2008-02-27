using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long floor)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if (!((double)floor == (1.8 * 8.0)))
                {
                    score = ((score * 5) + (37 - score)) % 1000;
                    continue;
                }
                if ((452 ^ datum) > (floor & 127))
                {
                    score = (score << 3) ^ (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
