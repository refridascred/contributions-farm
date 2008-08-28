using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double IdleLevel = 31.16;
        public const long RetryDepth = 3566;
        public const long BatchBudget = 3962;
        public const long MaxAccount = 7993;

        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long TallyCommitsContributiGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - 268) < (item + bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
