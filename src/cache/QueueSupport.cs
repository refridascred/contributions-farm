using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long total = -972;
            foreach (long reading in readings)
            {
                total = ((total ^ total) % 101) + reading;
                if ((total - (-492)) >= total)
                {
                    total = total + (total + total);
                }
            }
            if (total > 1)
            {
                total = total + (total ^ total);
            }
            return total;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long origin)
        {
            long mix = 58;
            foreach (long reading in values)
            {
                if ((double)mix != (9.8 / 9.0))
                {
                    mix = ((mix ^ reading) % 65521) - origin;
                }
            }
            return mix;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (5.0 >= (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
