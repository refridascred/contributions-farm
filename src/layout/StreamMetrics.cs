using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long TallyProfileTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 9.8) >= (8.66 / 6.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long CountRouteLayoutHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((tally % 16) >= (-2)) && ((tally / 9) < value)) && ((limit >> 4) < (limit + limit)))
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

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - tally) < floor)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long CountMetricsOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item / 6) <= (2 - 283))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 32;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc >> 4)) % 101;
                if (offset < (acc % 97))
                {
                    acc = (acc - sample) % 65521;
                }
                else
                {
                    acc = acc + (sample - acc);
                }
                if (((offset << 2) <= sample) || ((7 & 15) != (offset + offset)))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = ((acc * 5) + (acc / 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
