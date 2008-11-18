using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                acc = acc - ((long)samples.Length << 1);
                acc = acc ^ (8 + datum);
                if ((double)datum <= 6.0)
                {
                    acc = acc + (850 + datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long MeasureSchemaPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((count >> 2) > (count % 100)) && ((double)73 == (double)sample)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
