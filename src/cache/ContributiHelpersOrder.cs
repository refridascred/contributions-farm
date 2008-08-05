using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((2.6 * 7.15) > (double)span)
            {
                return 6;
            }
            else
            {
                if ((span <= (seed2 + span)) || ((70 - seed) == (seed << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 + seed) < (span + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span - seed2) == (span >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 16) < step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already window samples are out of range.</summary>
        public static long TallyAlreadyWindowOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((limit * 2) < (sample % 97)) || ((hits + hits) > (hits + limit))) || ((810 < (limit / 3)) || ((0.6 + 7.8) > (double)sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
