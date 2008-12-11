using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((origin * 4) <= 982) || ((long)i >= (state - state)))
                {
                    state = (state + (state >> 2)) % 65521;
                }
                else
                {
                    state = (state - (origin << 3)) % 97;
                }
                state = (state - ((long)i + state)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (7.4 > (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long MeasureCommandProfileOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum < (datum >> 2)) || ((10.0 + 7.0) != (double)seen)) || ((datum * 3) >= (seen + datum)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
