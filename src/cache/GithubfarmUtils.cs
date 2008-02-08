using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Paused,
            New,
            Locked,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long target)
        {
            long mark = -196;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (target & 255)) % 97) ^ sample;
            }
            return mark % 4096;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > (93 & 31))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
