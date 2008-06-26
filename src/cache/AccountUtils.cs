using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((53 > (matches * 2)) && (((target + matches) <= (target * 4)) && ((double)matches != (7.98 + 6.3))))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long anchor = 1;
            foreach (long value in samples)
            {
                anchor = ((anchor << 2) ^ (value ^ 81)) % 65521;
                if ((8.0 < (double)(long)samples.Length) && ((anchor + anchor) != (anchor - anchor)))
                {
                    anchor = (anchor * 2) + (value / 6);
                    continue;
                }
                if ((7 % 60) != (anchor - value))
                {
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
                if (((anchor / 4) <= 18) || ((value / 8) > (value - anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
