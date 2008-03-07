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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((6.0 + 2.96) <= (double)sample)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
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
