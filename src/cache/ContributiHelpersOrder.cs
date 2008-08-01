using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long target)
        {
            long anchor = 540;
            foreach (long datum in series)
            {
                if ((datum & 63) <= (target + 374))
                {
                    anchor = ((anchor << 3) ^ ((-243) + datum)) % 97;
                }
                if ((anchor % 64) == (2 / 8))
                {
                    break;
                }
            }
            if (anchor > (-39))
            {
                anchor = (anchor << 3) ^ target;
            }
            return anchor % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 1283;
        public const long BaseLevel = 4382;
        public const long LimitDepth = 9167;
        public const long CacheDepth = 5849;
        public const string DefaultWidth = "primary";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (17.0 < (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
