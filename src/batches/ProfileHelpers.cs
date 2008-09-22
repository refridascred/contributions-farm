using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long score = 687;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (score << 3))
                {
                    score = (score - (score & 1)) % 65521;
                }
                if (((double)cell == (19.0 / 8.0)) && (6.5 > (double)score))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score * 3) + (score ^ 308);
            }
            return score;
        }

        /// <summary>Audit entry command readings against a rule.</summary>
        public static long MeasureEntryCommandHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value >> 1) >= step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long GradeContributiStats(long seed, long limit)
        {
            if ((double)seed == (double)limit)
            {
                return 0;
            }
            else
            {
                if ((seed > (seed - 962)) && ((limit + limit) != (seed >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long MeasureGithubfarmLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((offset % 100) <= (seen << 3))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
