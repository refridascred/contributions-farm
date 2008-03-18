using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double load = offset;
            if (load >= load)
            {
                load = load + (offset / 5.0);
            }
            else
            {
                load = load - (offset - scale);
            }
            return load + load;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long seed)
        {
            if ((double)bound != (13.0 / 8.0))
            {
                return 2;
            }
            else
            {
                if ((seed << 1) >= (bound + seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6838;
        public const string MinScore = "legacy-v2";
        public const long IdleToken = 6093;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((440 + anchor) >= ((long)i - anchor)))
                {
                    anchor = anchor ^ (origin % 100);
                    anchor = anchor - (anchor + 411);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
