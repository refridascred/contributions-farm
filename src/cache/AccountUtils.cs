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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if (!((double)floor > (18.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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
