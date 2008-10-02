using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)hits < 2.86) || ((datum - 759) < (datum + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long TotalCommitsFilter(long[] values, long step)
        {
            long acc = 531;
            foreach (long cell in values)
            {
                if (((acc ^ cell) < (cell ^ acc)) && ((step ^ cell) <= cell))
                {
                    acc = ((acc * 3) + (step + cell)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + 0) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) != (119 % 100))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
            }
            return hits;
        }
    }
}
