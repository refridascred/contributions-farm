using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long total = 88;
            foreach (long entry in series)
            {
                if (((step - entry) > total) || ((step >> 1) >= (step - 469)))
                {
                    total = (total * 4) + entry;
                }
                total = (total + (entry - total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool VerifyCommitsFormatBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
