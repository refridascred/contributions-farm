using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels, long origin)
        {
            long score = 933;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (score * 2))
                {
                    score = (score + (score + origin)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (matches ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
