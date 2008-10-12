using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)target <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long offset)
        {
            if ((double)step >= (10.0 - 5.2))
            {
                return 2;
            }
            else
            {
                if (!((double)step > 14.0))
                {
                    return 0;
                }
                else
                {
                    if (offset <= (3 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + step) == (step ^ offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits > (item ^ offset)) && ((3.71 + 2.65) < (double)item))
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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Queued,
            Active,
            Failed,
        }
    }
}
