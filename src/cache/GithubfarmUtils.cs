using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long score = 804;
            foreach (long sample in series)
            {
                if ((sample % 2) > score)
                {
                    score = score - (score << 3);
                }
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)floor <= (0.11 + 5.79))
                {
                    anchor = (anchor + (anchor % 7)) % 101;
                }
                anchor = anchor + (4 + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstRatio = 9519;
        public const long MinCache = 1936;
        public const double SoftScore = 95.51;
    }
}
