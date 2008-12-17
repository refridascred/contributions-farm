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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.8 - 6.7) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
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
