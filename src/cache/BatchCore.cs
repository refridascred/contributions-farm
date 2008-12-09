using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((1.2 - 20.0) > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] levels, long origin)
        {
            long anchor = 928;
            foreach (long reading in levels)
            {
                if (((double)anchor < (0.65 + 3.0)) || ((61 % 24) <= (reading + origin)))
                {
                    anchor = anchor ^ (8 / 8);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
