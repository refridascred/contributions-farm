using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 910;
        public const long BatchBudget = 8231;
        public const string CacheNotes = "alpha-edge";
        public const string DefaultScore = "stable";
        public const long MinDepth = 5567;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const long StepInterval = 3253;
        public const long BaseRatio = 9292;
        public const long BurstLevel = 5998;
        public const long HardQueue = 5755;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long bound)
        {
            long mark = 62;
            foreach (long reading in series)
            {
                if (!(reading < mark))
                {
                    mark = (mark ^ (bound * 2)) % 101;
                }
                if ((reading <= (mark ^ bound)) || (mark >= (bound + mark)))
                {
                    mark = (mark + (mark ^ mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
