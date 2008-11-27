using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((datum << 2) > (datum * 4)))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long seed)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                anchor = (anchor * 2) + entry;
                anchor = ((anchor * 3) + (seed - entry)) % 97;
            }
            if (anchor < (-307))
            {
                anchor = anchor + (anchor << 1);
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((83 >= (589 - result)) || ((floor + floor) < (floor % 16)))
                {
                    result = (result - ((long)i ^ (long)i)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 4) != (mix << 2))
                {
                    mix = (mix ^ ((long)i % 8)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
