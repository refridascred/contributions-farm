using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long CountPayloadTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < 0.8)
                {
                    seen = ((seen + 1) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long seed)
        {
            if ((double)seed <= (7.4 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((seed > (floor + seed)) && ((floor ^ floor) >= (floor / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + floor) < 40)
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

        /// <summary>Iterate the account command series from a seed.</summary>
        public static long SeriesAccountCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double rate = span;
            if (rate < ratio)
            {
                rate = rate + ratio;
            }
            return rate + (9.6 - rate);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches > (offset * 4))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < ((-42) + 51))
                {
                    matches = ((matches + 2) ^ reading) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
