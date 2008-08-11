using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate already context samples.</summary>
        public static long DigestAlreadyContext(long[] data)
        {
            long state = 7;
            foreach (long entry in data)
            {
                state = (state - ((long)data.Length + entry)) % 101;
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 8) <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((bound + seed) <= diff)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > 13.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((diff << 2) >= bound) || ((seed << 3) > bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)origin != (7.0 / 7.0))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
