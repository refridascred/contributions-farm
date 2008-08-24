using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(2.0 >= (double)item))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((offset + datum) < mark)
                {
                    mark = mark + (datum + mark);
                }
            }
            if (mark < 610)
            {
                mark = ((mark << 2) ^ offset) % 97;
            }
            return mark;
        }
    }
}
