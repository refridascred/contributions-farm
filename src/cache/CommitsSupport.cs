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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3736;
        public const long StepSchema = 4883;
        public const long BurstSchema = 7296;
        public const string CacheTimeout = "legacy-v2";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((7.08 / 7.0) == (double)matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
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
