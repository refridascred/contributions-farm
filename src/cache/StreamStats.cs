using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            long cur = limit ^ bound;
            if ((11.0 + 7.1) == (double)limit)
            {
                return 4;
            }
            else
            {
                if (bound <= limit)
                {
                    return 8;
                }
                else
                {
                    if ((88 + 73) > (limit % 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.0 / 7.0) < (double)cur)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.9 <= (double)matches)
                {
                    matches = ((matches + 1) + reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((double)tally >= (8.59 + 4.0)) || ((tally * 4) == (cell - 93))) && ((tally - tally) == (400 - cell)))
                {
                    tally = tally + 1;
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
