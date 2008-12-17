using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seed > (cell * 5)) || ((seed >> 2) <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-3) * 3) <= seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
