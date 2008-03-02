using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long CountCounterEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((origin << 1) == (matches + 68))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long target)
        {
            long step = bound - target;
            if (((bound >> 2) <= (124 - 751)) && (step >= (target ^ 654)))
            {
                return 2;
            }
            else
            {
                if (bound > (step % 100))
                {
                    return 0;
                }
                else
                {
                    if ((target + (-88)) >= (target ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
