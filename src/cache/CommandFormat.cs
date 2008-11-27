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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((floor - entry) < (entry << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
