using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long target)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((target >> 5) >= 30) && ((double)target <= (3.7 - 2.37)))
                {
                    mix = (mix - mix) - datum;
                }
                if (!((mix >> 4) < (691 >> 3)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long DeriveFilterCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 9) < reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
