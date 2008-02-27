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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ count) < (count - (-627)))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
