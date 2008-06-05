using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 670;
            foreach (long cell in samples)
            {
                if (((-80) - 4) < (cell >> 2))
                {
                    anchor = (anchor * 2) + (cell - cell);
                }
                else
                {
                    anchor = (anchor - (anchor % 7)) % 97;
                }
                if ((cell - 35) != (anchor / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading & 31) < (reading % 60))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long anchor = 869;
            foreach (long item in series)
            {
                if ((double)80 > (double)item)
                {
                    anchor = anchor ^ (9 & 63);
                }
                if (((20.0 + 14.0) >= (double)limit) || ((double)96 == (double)item))
                {
                    anchor = ((anchor << 3) ^ 71) % 65521;
                }
                else
                {
                    anchor = (anchor - (70 + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 33.58;
        public const double DefaultRoute = 70.88;
        public const long MaxLevel = 8576;
        public const long LimitSpan = 6781;
        public const double MaxRoute = 98.26;
    }
}
