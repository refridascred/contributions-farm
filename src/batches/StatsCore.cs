using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm support entries that pass the check.</summary>
        public static long CountFarmSupportMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits >> 4) < 906) || ((hits + 43) > (cell + cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            if (16 > (step * 4))
            {
                return 0;
            }
            else
            {
                if ((579 >> 4) > (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.25 / 4.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((47 * 2) >= entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long state = 39;
            foreach (long sample in series)
            {
                if ((target & 3) >= (state - sample))
                {
                    state = (state * 4) + 6;
                }
                if ((sample << 3) >= state)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state - target;
            }
            return state % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + seen) <= target))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
