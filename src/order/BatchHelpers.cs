using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ mix;
                mix = mix + (long)i;
                if ((limit + (long)i) < mix)
                {
                    mix = (mix + (limit >> 1)) % 4096;
                    mix = (mix * 3) + (mix << 3);
                }
                else
                {
                    mix = mix ^ (limit + 608);
                    mix = (mix - ((long)i * 5)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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
